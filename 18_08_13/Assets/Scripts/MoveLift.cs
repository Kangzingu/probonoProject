using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLift : MonoBehaviour {
    public GameObject liftAxis;
    public GameObject step;
    public GameObject lift;
    Transform player;

    int count;
    int countMax;

    float speed;

    bool rotLift;
    bool operateStep;
    bool transLift;
    bool playerOn;
    // Use this for initialization
	void Start () {
        rotLift = false;
        operateStep = false;
        transLift = false;
        playerOn = false;

        count = 0;
        speed = 1.0f;
        countMax = (int)(90 / speed);
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rotLift = true;
        }
        if (rotLift == true)
        {
            RotateLift();
        }
        if (operateStep == true)
        {
            OperatreStep();
        }
        if (transLift == true && playerOn == true)
        {
            TransLift();
        }
    }
    void RotateLift()
    {
        if (count < countMax)
        {
            liftAxis.transform.Rotate(new Vector3(speed, 0, 0));
            count++;
        }
        if (count == countMax)
        {
            rotLift = false;
            operateStep = true;
            count = 0;
            speed = 0.005f;
            countMax = (int)(0.45 / speed);
        }
    }
    void OperatreStep()
    {
        if (count < countMax)
        {
            step.transform.position+=(new Vector3(speed, 0, 0));
            count++;
        }
        if (count == countMax)
        {
            operateStep = false;
            transLift = true;
            count = 0;
            speed = 0.02f;
            countMax = (int)(7.3 / speed);
        }
    }
    void TransLift()
    {
        if (count < countMax)
        {
            lift.transform.position += (new Vector3(-speed, speed, 0));
            player.position += (new Vector3(-speed, speed, 0));
            count++;
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            player = other.transform;
            playerOn = true;
        }
    }
}
