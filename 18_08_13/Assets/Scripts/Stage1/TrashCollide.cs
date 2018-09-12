using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCollide : MonoBehaviour {
    public GameObject gameDirector;
    public GameObject Trash;//쓰레기
    // Use this for initialization
    void Start () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")//쓰레기에 플레이어가 충돌한 경우
        {
            gameDirector.GetComponent<GameDirector>().TrashCollide();
            //gamedirector 함수
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
