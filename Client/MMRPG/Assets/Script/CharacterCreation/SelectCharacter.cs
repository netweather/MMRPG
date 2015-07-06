/*=========================
 * 选择角色脚本
 * 
 * 2015年7月6日
 * ========================
 */
 

using UnityEngine;
using System.Collections;

public class SelectCharacter : MonoBehaviour {
	
	public GameObject[] hero;                    //你的英雄
	public GameObject buttonNext,buttonPrev;     //上一个按钮和下一个按钮

	[HideInInspector]
    public int indexHero = 0;                    //索引选择的英雄
	
	private GameObject[] heroInstance;           //实例化英雄实例
	
	// Use this for initialization
	void Start () {

        heroInstance = new GameObject[hero.Length]; //添加尺寸数组大小相等的英雄
        indexHero = 0;                           //设置默认选中的英雄
		SpawnHero();                             //显示被选英雄函数


        //检查英雄是否小于1 , 按钮下和上将会消失
		if(hero.Length <= 1)
		{
			buttonNext.SetActive(false);
			buttonPrev.SetActive(false);
		}
		
	
	}

    //检查并显示选定的角色
	public void UpdateHero(int _indexHero)
	{
		for(int i=0; i<hero.Length;i++)
		{
            //只显示选择角色
			if(i == _indexHero)
			{
				heroInstance[i].SetActive(true);
			}else
			{
                //隐藏其他角色
				heroInstance[i].SetActive(false);
			}		
		}
	}

    //产生所有的英雄
	public void SpawnHero()
	{
		for(int i=0;i<hero.Length;i++)
		{
			heroInstance[i] = (GameObject)Instantiate(hero[i],transform.position,transform.rotation);
		}
		
		UpdateHero(indexHero);
	}
	
}
