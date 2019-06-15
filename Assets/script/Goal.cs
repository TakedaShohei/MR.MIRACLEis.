using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {
    public static bool goal;
	// Use this for initialization
	void Start () {
        goal = false;
	}
	
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            goal = true;
            SceneManager.LoadScene("clear");
        }
    }


	// Update is called once per frame
	void Update () {
		
	}
}
