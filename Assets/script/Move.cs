using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadingNewScene()
    {
        SceneManager.LoadScene("Chose");
      

    }

    public void LoadingNewScene2()
    {
        SceneManager.LoadScene("stage1");
    }
    public void LoadingStage2Scene()
    {
        SceneManager.LoadScene("stage2");
    }
    public void LoadingGameOverScene()
    {
        SceneManager.LoadScene("gameover");
    
    }
    public void LoadingClearScene()
    {
        SceneManager.LoadScene("clear");

    }
   


}
