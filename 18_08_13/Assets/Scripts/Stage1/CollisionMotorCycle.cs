using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMotorCycle : MonoBehaviour {
    public GameDirector gameDirector;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            //오토바이가 플레이어와 닿음
            gameDirector.GetComponent<GameDirector>().CollisionMotorCycle();
            Debug.Log("CollsionMotorCycle 호출");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            //오토바이가 플레이어와 닿음
            gameDirector.GetComponent<GameDirector>().ExitCollisionMotorCycle();
            Debug.Log("ExitCollsionMotorCycle 호출");
        }

    }
}
