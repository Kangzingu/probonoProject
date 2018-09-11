using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarGenerator : MonoBehaviour {
    public GameObject CarPrefab;
    float delta;

	// Use this for initialization
	void Start () {
        delta = 0;
	}
	
	// Update is called once per frame
	void Update () {
        this.delta += Time.deltaTime;

        if (delta % 60 == 0)
        {
            GameObject car;
            car = Instantiate(CarPrefab) as GameObject;

            float x;
            float z;

            switch (Random.Range(0, 8))
            {
                case 0:
                    x = 0;
                    z = 0;
                    break;
                case 1:
                    x = 0;
                    z = 0;
                    break;
                case 2:
                    x = 0;
                    z = 0;
                    break;
                case 3:
                    x = 0;
                    z = 0;
                    break;
                case 4:
                    x = 0;
                    z = 0;
                    break;
                case 5:
                    x = 0;
                    z = 0;
                    break;
                case 6:
                    x = 0;
                    z = 0;
                    break;
                case 7:
                    x = 0;
                    z = 0;
                    break;
                default:
                    x = 0;
                    z = 0;
                    break;
            }
            car.transform.position = new Vector3(x, 0, z);
        }
    }
}
