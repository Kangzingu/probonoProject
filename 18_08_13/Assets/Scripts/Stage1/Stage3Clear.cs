using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3Clear : MonoBehaviour {

    public GameObject gameDirector;
    public GameObject Stage3;//stage3 경계
    void Start () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")//stage3 경계에 플레이어가 도달한 경우
        {
            gameDirector.GetComponent<GameDirector>().Stage3Clear();
            //gamedirector 함수
            Destroy(Stage3);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
