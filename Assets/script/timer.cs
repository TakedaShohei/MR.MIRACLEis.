using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timer : MonoBehaviour {

    public GameObject panelGameOver;
    public float time;
    public TextMeshProUGUI uiText = null;

    public System.Action finishCallback = null;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        if (time < 0) time = 0;
        int timer = Mathf.FloorToInt(time);

        //Text uiText = GetComponent<Text>();
        uiText.text = "Time:" + timer;

        if (time <= 0)
        {
            if (finishCallback != null)
            {
                finishCallback();
            }
        }
        
    }
}
