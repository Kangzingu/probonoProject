using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BCarMove : MonoBehaviour {

    GameObject Car;
    int state;

	// Use this for initialization
	void Start () {
        Car = GameObject.Find("Car");
        state = 0;
	}
	
	// Update is called once per frame
	void Update () {

        switch (state)
        {
            case 0:
                Car.transform.Translate(0, 0, 1.0f); 
                break;
            case 1:
                
                break;
        }
        // 차량들 이동

	}

    void OnTriggerEnter(Collider other)
    {

    }
}
