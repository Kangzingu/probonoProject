using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage4Clear : MonoBehaviour {

    public GameObject gameDirector;
    public GameObject Stage4;//stage4 경계
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")//stage4 경계에 플레이어가 도달한 경우
        {
            gameDirector.GetComponent<GameDirector>().Stage4Clear();
            //gamedirector 함수
            Destroy(Stage4);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
