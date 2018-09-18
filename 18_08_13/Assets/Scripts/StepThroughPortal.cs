using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepThroughPortal : MonoBehaviour {

    public GameObject otherPortal;
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
            //other.transform.position = otherPortal.transform.position + otherPortal.transform.forward * 1;
            //other.transform.TransformDirection = otherPortal.transform.TransformDirection;

            //other.transform.position = otherPortal.transform.position + otherPortal.transform.forward * 1;
            //other.attachedRigidbody.velocity= otherPortal.transform.forward*1;

            float power = other.GetComponent<CharacterController>().velocity.magnitude +
                other.GetComponent<CharacterController>().velocity.y;
            Debug.Log(power);
            if (power >= 3)
            {//어느정도 속도가 있었을때
                other.transform.position = otherPortal.transform.position + otherPortal.transform.forward * power;
            }
            else
            {
                other.transform.position = otherPortal.transform.position + otherPortal.transform.forward * 3;
            }
        }
        if (other.tag == "MovingObject")
        {
            Vector3 overallVelocity = new Vector3(other.GetComponent<Rigidbody>().velocity.x, other.GetComponent<Rigidbody>().velocity.y, other.GetComponent<Rigidbody>().velocity.z);
            float power = overallVelocity.magnitude;
            Debug.Log(power);
            if (power >= 3)
            {//어느정도 속도가 있었을때
                other.transform.position = otherPortal.transform.position + otherPortal.transform.forward * power;
                other.GetComponent<Rigidbody>().AddForce(otherPortal.transform.forward * power);
            }
            else
            {
                other.transform.position = otherPortal.transform.position + otherPortal.transform.forward * 3;
            }
        }
    }
}
