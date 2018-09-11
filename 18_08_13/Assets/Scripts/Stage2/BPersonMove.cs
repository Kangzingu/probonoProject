using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPersonMove : MonoBehaviour {

    GameObject Person;
	// Use this for initialization
	void Start () {
        Person = GameObject.Find("Person");
       
	}
	
	// Update is called once per frame
	void Update () {
        int rand = Random.Range(0, 5);

        Person.transform.Translate(0, 0, 0.05f);
	}
}
