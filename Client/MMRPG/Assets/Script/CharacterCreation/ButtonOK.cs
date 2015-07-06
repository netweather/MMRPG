/// <summary>
/// This script use for detect button ok
/// To change texture button normal-down and call load scene when click this button
/// </summary>

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonOK : MonoBehaviour {
	
	public string loadSceneName;    //Next load scene name
	
//	public Texture2D buttonOkNormal;  //Texture button normal
//	public Texture2D buttonOkDown;   //Texture button down
	public InputField Inp_Name;  //script entername
	public SelectCharacter selectCharacterScript; //script select character
	public AudioClip sfxButton;  //sound effect when click this button

	public void ButOK()
	{
		//change texture to "normal"
		//this.gameObject.GetComponent<GUITexture>().texture = buttonOkNormal;
        string strName = Inp_Name.text;
        if (strName !="")
        {


             Debug.Log("UserName");
           
        }
        else
        {
            strName = "PlayName";
            Debug.Log("PlayName");
            
        }
           //Save select character and name
            PlayerPrefs.SetString("pName", strName);
            PlayerPrefs.SetInt("pSelect", selectCharacterScript.indexHero);

            SpawnPointHero.enableLoadData = true;

            //Load next scene
            //Invoke("LoadScene",0.1f);
            Debug.Log(strName);
           AudioSource.PlayClipAtPoint(sfxButton, transform.position);
	}
		
	void LoadScene()
	{
		Application.LoadLevel(loadSceneName);;	
	}
}
