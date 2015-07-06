/*=========================
 * ѡ���ɫ�ű�
 * 
 * 2015��7��6��
 * ========================
 */
 

using UnityEngine;
using System.Collections;

public class SelectCharacter : MonoBehaviour {
	
	public GameObject[] hero;                    //���Ӣ��
	public GameObject buttonNext,buttonPrev;     //��һ����ť����һ����ť

	[HideInInspector]
    public int indexHero = 0;                    //����ѡ���Ӣ��
	
	private GameObject[] heroInstance;           //ʵ����Ӣ��ʵ��
	
	// Use this for initialization
	void Start () {

        heroInstance = new GameObject[hero.Length]; //��ӳߴ������С��ȵ�Ӣ��
        indexHero = 0;                           //����Ĭ��ѡ�е�Ӣ��
		SpawnHero();                             //��ʾ��ѡӢ�ۺ���


        //���Ӣ���Ƿ�С��1 , ��ť�º��Ͻ�����ʧ
		if(hero.Length <= 1)
		{
			buttonNext.SetActive(false);
			buttonPrev.SetActive(false);
		}
		
	
	}

    //��鲢��ʾѡ���Ľ�ɫ
	public void UpdateHero(int _indexHero)
	{
		for(int i=0; i<hero.Length;i++)
		{
            //ֻ��ʾѡ���ɫ
			if(i == _indexHero)
			{
				heroInstance[i].SetActive(true);
			}else
			{
                //����������ɫ
				heroInstance[i].SetActive(false);
			}		
		}
	}

    //�������е�Ӣ��
	public void SpawnHero()
	{
		for(int i=0;i<hero.Length;i++)
		{
			heroInstance[i] = (GameObject)Instantiate(hero[i],transform.position,transform.rotation);
		}
		
		UpdateHero(indexHero);
	}
	
}
