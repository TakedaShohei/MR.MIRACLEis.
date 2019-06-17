using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Quits : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }
    public void Quit()
    {
        
           UnityEditor.EditorApplication.isPlaying = false;
       
		   Application.Quit();
    }
    public void EndGame()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_WEBPLAYER
		        Application.OpenURL("http://www.yahoo.co.jp/");
        #else
		        Application.Quit();
        #endif
    }

    // Update is called once per frame
    void Update()
    {

    }
}
