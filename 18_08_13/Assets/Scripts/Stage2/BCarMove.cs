using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BCarMove : MonoBehaviour
{

    GameObject[] Cars;
    int state;

    // Use this for initialization
    void Start()
    {
        //      Cars = GameObject.FindGameObjectsWithTag("BCar");
        state = 0;

    }

    // Update is called once per frame
    void Update()
    {
        Cars = GameObject.FindGameObjectsWithTag("BCar");
        switch (state)
        {
            case 0:
                foreach (GameObject car in Cars)
                    car.GetComponent<Rigidbody>().AddForce(new Vector3(500, 0, 0));

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
