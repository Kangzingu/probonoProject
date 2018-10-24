using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour {
    Animator playerAnimator;
    private float h;
    private float v;
    // Use this for initialization
    void Start () {
        playerAnimator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        playerAnimator.SetFloat("h", h);
        playerAnimator.SetFloat("v", v);
    }
}
