using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCar : MonoBehaviour {

    public GameObject gameDirector;
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            //오토바이가 플레이어와 닿음
            gameDirector.GetComponent<GameDirector>().CollisionCar();
            Debug.Log("CollsionCar 호출");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            //오토바이가 플레이어와 닿음
            gameDirector.GetComponent<GameDirector>().ExitCollisionCar();
            Debug.Log("ExitCollsionCar 호출");
        }

    }
}
