/*==========================
 * ��ťѡ���ɫ�ű�
 * ����ű�ʹ��(next and prev )��ťѡ���ɫ
 * 2015��7��6��
 * ===========================
 */

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonSelected : MonoBehaviour {
	
	public string buttonName;                    //��ť����
	public SelectCharacter selectCharacterScript;//ѡ���ɫ�ű�
    public AudioClip sfxButton;                  //����ð�ťʱ����Ч��

    public void ButSet()
	{
		if(buttonName == "Next")                 //�����ť������=Next  �����������ťʱѡ��֮ǰ�Ľ�ɫ
		{
            
			selectCharacterScript.indexHero += 1;
			
			if(selectCharacterScript.indexHero >= selectCharacterScript.hero.Length)
			{
				selectCharacterScript.indexHero = 0;
			}
			
			selectCharacterScript.UpdateHero(selectCharacterScript.indexHero);
            
			
		}
		
		//�����ť������=Prev  �����������ťʱѡ��֮ǰ�Ľ�ɫ
		
		if(buttonName == "Prev")
		{
			selectCharacterScript.indexHero -= 1;	
			
			if(selectCharacterScript.indexHero < 0)
			{
				selectCharacterScript.indexHero = selectCharacterScript.hero.Length-1;
			}
			
			selectCharacterScript.UpdateHero(selectCharacterScript.indexHero);
           
		}

        MouseDownAudio();                        //����������Ч
	}
	
   void MouseDownAudio()                          //���岥��������Ч
	{

		AudioSource.PlayClipAtPoint(sfxButton,transform.position);
	  //AudioSource.PlayClipAtPoint ��ָ��λ�ò��ż���
	}
	

}
