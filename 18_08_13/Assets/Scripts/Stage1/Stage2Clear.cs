using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2Clear : MonoBehaviour {

    public GameObject gameDirector;
    public GameObject Stage2;//stage2 경계
    void Start () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")//stage2 경계에 플레이어가 도달한 경우
        {
            gameDirector.GetComponent<GameDirector>().Stage2Clear();
            //gamedirector 함수
            Destroy(Stage2);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
