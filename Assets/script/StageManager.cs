using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour {

    [SerializeField] timer timer_;
    [SerializeField] gameOver game_over_;

	// Use this for initialization
	void Start () {
        timer_.finishCallback = game_over_.GameOver;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
