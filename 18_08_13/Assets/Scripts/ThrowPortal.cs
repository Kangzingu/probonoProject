using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowPortal : MonoBehaviour {
    public GameObject leftPortal;
    public GameObject rightPortal;
    GameObject mainCamera;
    HoldObject holdObject;
    // Use this for initialization
    void Start () {
        mainCamera = GameObject.FindWithTag("MainCamera");
        holdObject = GameObject.Find("FPSController").GetComponent<HoldObject>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("left click");
            throwPortal(leftPortal);
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("right click");
            throwPortal(rightPortal);
        }
    }
    void throwPortal(GameObject portal)
    {
        int x = Screen.width / 2;//스크린 중심
        int y = Screen.height / 2;// "

        Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x, y));
        //이거 이상행 ㅠ
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit))
        {
            if (holdObject.holdObject == hit.collider)
            {//들고있는거에 포탈 부딫혔을땡
                Debug.Log("아오 부딫힘");
            }
            Quaternion hitObjectRotation = Quaternion.LookRotation(hit.normal);
            //노말벡터따라 바꿈, 표창마냥 박히는거말고 벽에 딱붙게
            portal.transform.position = hit.point;
            portal.transform.rotation = hitObjectRotation;
        }
    }
}
