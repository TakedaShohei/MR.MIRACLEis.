﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Retry : MonoBehaviour {

   
    
   
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
    
       
    }
    public void OnRetry()
    {
        SceneManager.LoadScene(
            SceneManager.GetActiveScene().name);
    }

   
}
