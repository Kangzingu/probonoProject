using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1Clear : MonoBehaviour {
    public GameObject gameDirector;
    public GameObject Stage1;//stage1 경계
    // Use this for initialization
    void Start () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")//stage1 경계에 플레이어가 도달한 경우
        {
            gameDirector.GetComponent<GameDirector>().Stage1Clear();
            //gamedirector 함수
            Destroy(Stage1);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
