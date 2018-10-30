using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //화면 변환시 사용

public class GoStage1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void LoadStage1()
    {
        SceneManager.LoadScene("Stage1");
    }
}
