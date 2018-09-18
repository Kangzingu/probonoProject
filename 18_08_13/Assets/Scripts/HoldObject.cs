using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldObject : MonoBehaviour
{
    GameObject player;
    GameObject mainCamera;
    public Collider holdObject;
    bool hold;
    // Use this for initialization
    void Start()
    {
        
        player = GameObject.FindWithTag("Player");
        mainCamera = GameObject.FindWithTag("MainCamera");
        hold = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (hold == true)
        {
            holdObject.transform.position = player.transform.position + player.transform.forward * 2;
            //손에 들장
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            int x = Screen.width / 2;
            int y = Screen.height / 2;
            Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x, y));
            RaycastHit hit;
            if (hold == true)
            {//들고있었다면
                hold = false;//내려놓자^^
            }
            else//hold==false
            {//들고있지 않다면?
                if (Physics.Raycast(ray, out hit))
                {//레이져쏘고
                    if (hit.collider.tag == "MovingObject")
                    {//움직일수 있는넘이면
                        hold = true;
                        holdObject = hit.collider;
                        //손에 들자^^

                        //hit.transform.position
                        //Debug.Log("해냈다궁");
                        //hit.collider.transform.position=
                    }
                }
            }
        }
    }
}
