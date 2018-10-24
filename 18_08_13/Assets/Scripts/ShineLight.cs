using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShineLight : MonoBehaviour {
    public GameObject player;
    public GameObject mLight;
    public GameObject mainCamera;
    Vector3 diff;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            int x = Screen.width / 2;
            int y = Screen.height / 2;
            Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x, y));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                diff = (mainCamera.transform.position - hit.point) / 10;
                if (Vector3.Distance(new Vector3(0, 0, 0), diff) < 0.55f)
                    mLight.transform.position = hit.point + diff;
            }
        }
	}
}
