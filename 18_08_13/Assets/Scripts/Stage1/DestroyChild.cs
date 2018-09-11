using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyChild : MonoBehaviour {

    public GameObject gameDirector;
    //public GameObject Stage1;//stage1 경계
    // Use this for initialization
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MChild")//반대편 대문에 아기가 도달한 경우
        {
            gameDirector.GetComponent<GameDirector>().DestroyChild();
            //gamedirector 함수
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
