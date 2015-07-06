/*==========================
 * 按钮选择角色脚本
 * 这个脚本使用(next and prev )按钮选择角色
 * 2015年7月6日
 * ===========================
 */

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonSelected : MonoBehaviour {
	
	public string buttonName;                    //按钮名字
	public SelectCharacter selectCharacterScript;//选择角色脚本
    public AudioClip sfxButton;                  //点击该按钮时音响效果

    public void ButSet()
	{
		if(buttonName == "Next")                 //如果按钮的名字=Next  当单击这个按钮时选择之前的角色
		{
            
			selectCharacterScript.indexHero += 1;
			
			if(selectCharacterScript.indexHero >= selectCharacterScript.hero.Length)
			{
				selectCharacterScript.indexHero = 0;
			}
			
			selectCharacterScript.UpdateHero(selectCharacterScript.indexHero);
            
			
		}
		
		//如果按钮的名字=Prev  当单击这个按钮时选择之前的角色
		
		if(buttonName == "Prev")
		{
			selectCharacterScript.indexHero -= 1;	
			
			if(selectCharacterScript.indexHero < 0)
			{
				selectCharacterScript.indexHero = selectCharacterScript.hero.Length-1;
			}
			
			selectCharacterScript.UpdateHero(selectCharacterScript.indexHero);
           
		}

        MouseDownAudio();                        //播放声音特效
	}
	
   void MouseDownAudio()                          //定义播放声音特效
	{

		AudioSource.PlayClipAtPoint(sfxButton,transform.position);
	  //AudioSource.PlayClipAtPoint 在指定位置播放剪辑
	}
	

}
