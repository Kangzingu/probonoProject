using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyStudnets : MonoBehaviour {

    public GameObject gameDirector;
    // Use this for initialization
    void Start () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MStudents")//학생이 도달한 경우
        {
            gameDirector.GetComponent<GameDirector>().DestroyStudents();
            //gamedirector 함수
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
