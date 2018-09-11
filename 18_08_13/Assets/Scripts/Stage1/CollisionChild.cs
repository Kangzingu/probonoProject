using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionChild : MonoBehaviour {
    public GameObject gameDirector;

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
            //아이가 플레이어와 닿음
            gameDirector.GetComponent<GameDirector>().CollsionChild();
            Debug.Log("collision child 호출");
        }
    }
  
}
