using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage6Clear : MonoBehaviour
{

    public GameObject gameDirector;
    public GameObject Stage6;//stage6 경계
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MStudents")//stage6 경계에 학생들이 도달한 경우
        {
            gameDirector.GetComponent<GameDirector>().Stage6Clear();
            //gamedirector 함수
            Destroy(Stage6);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
