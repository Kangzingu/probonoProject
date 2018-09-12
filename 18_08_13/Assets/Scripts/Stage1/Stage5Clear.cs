using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage5Clear : MonoBehaviour {

    public GameObject gameDirector;
    public GameObject Stage5;//stage5 경계
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")//stage5 경계에 플레이어가 도달한 경우
        {
            gameDirector.GetComponent<GameDirector>().Stage5Clear();
            //gamedirector 함수
            Destroy(Stage5);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
