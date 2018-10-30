using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour {
    // Use this for initialization
    public Light m_light1, m_light2, m_light3, m_light4;

    public GameObject door;
    bool isDoorStart;
    bool isOpened;
    int rotateCount;

    public GameObject mChild;
    bool isChildStart;

    public GameObject mMotorCycle;
    bool isMotorCycleStart;

    public GameObject mCar;
    bool isCarStart;

    public GameObject mPeople;
    bool isPeoplesStart;
    bool isPeopleTurnStart;
    float turnValue;

    public GameObject mPlayer;

    bool isLightOn;

    float count = 1.0f;
    void Start () {
        isOpened = false;
        isDoorStart = false;
        rotateCount = 0;
        turnValue= 90.0f;
        //door 제어

        isChildStart = false;
        isCarStart = false;
        isPeoplesStart = false;
        isPeopleTurnStart = false;

        //가로등 불 제어
        isLightOn = false;

    }
    // Update is called once per frame
    void Update () {
        if (isDoorStart == true)//문 열기 시작
        {
            Debug.Log(rotateCount);
            if (rotateCount > 30)//90도 이상 열렸다면
            {
                //회전 멈추고
                Debug.Log("child뛰기시작");
                isDoorStart = false;//문 그만 작동
                isOpened = true;//다 열렸다!
            }
            else//아직 다 안열렸다면
            {
                door.transform.Rotate(new Vector3(0, -3, 0));//조금씩 열자
                rotateCount++;
            }

            if (isOpened == true)//만약 다 열렸다면
            {
                this.ChildRun();
                //애기 뛰어라
            }

        }
        if (isChildStart == true)//애기 뛰는거 시작
        {
            //mChild.transform.Translate(0.1f, 0, 0);
            //mChild.GetComponent<Rigidbody>().AddForce(10,0,0);
            //isChildStart = false;
            mChild.GetComponent<Animator>().SetFloat("h", 1.0f);
        }
        if (isMotorCycleStart == true)//오토바이 출발
        {
            mMotorCycle.transform.Translate(0, 0, 0.1f);
        }
        if (isCarStart == true)//차 출발
        {
            //mCar.transform.Translate(0, 0, 0.25f);
        }
        if (isPeoplesStart == true)//아이 출발
        {
            mPeople.transform.Translate(-0.015f,0,0);
        }
        if (isPeopleTurnStart == true)//학생들이 한번만 돈다
        {
            turnValue += -0.5f;
            mPeople.transform.Rotate(0, -0.5f, 0);
            //한번만 돌게 한다.
            if (turnValue < 0) {
                isPeopleTurnStart = false;
            }
            
        }

        if (isLightOn == true)
        {
            //   Debug.Log("m_light1_on");
            if (count>30.0f)
            {
                m_light1.enabled = false;
                m_light2.enabled = false;
                m_light3.enabled = false;
                m_light4.enabled = false;

                isLightOn = false;
                count = 0;
            }
            else
            {
                count =count * Time.deltaTime;
                m_light1.enabled = true;
                m_light2.enabled = true;
                m_light3.enabled = true;
                m_light4.enabled = true;
                Debug.Log(count);
            }
           
        }


    }
    public void Stage1Clear()
    {
        Debug.Log("Stage1Clear");
        isLightOn = true;
    }
    public void Stage2Clear()
    {
        Debug.Log("Stage2Clear");
        //문돌리기 시작
        this.DoorRotate();
    }
    public void Stage3Clear()
    {
        Debug.Log("Stage3Clear");
        isChildStart = false;//애기 그만움직이게
        this.MotorCycleStart();//오토바이 출발

    }
    public void Stage4Clear()
    {
        Debug.Log("Stage4Clear");
        //this.CarStart();
        //차가 앞에서 출발함
        
    }
    public void Stage5Clear()
    {
        Debug.Log("Stage5Clear");
        this.ChildsStart();
    }
    public void Stage6Clear()
    {
        Debug.Log("Stage6Clear");
        this.ChildTurnStart();
    }

    public void TrashCollide()
    {
        Debug.Log("TrashCollide");
    }                                 
    public void DoorRotate()
    {
        isDoorStart = true;//문 열자
    }
    public void ChildRun()
    {
        mChild.GetComponent<Animator>().SetBool("isChildStart", true);
        isChildStart = true;//애기 뛰게 하자
    }
    public void MotorCycleStart()
    {
        mMotorCycle.transform.position = new Vector3(18, 0, -15);
        isMotorCycleStart = true;
    }
    public void CarStart()
    {
        isCarStart = true;//차를 움직인다.
    }
    public void ChildsStart()
    {
        isPeoplesStart = true;//아이들을 움직인다.
    }
    public void ChildTurnStart()
    {
        this.isPeopleTurnStart = true;//학생들이 돌아서 나가도록 한다.
    }
    public void DestroyChild()
    {
        Debug.Log("DestroyChild");
        Destroy(mChild);//아이를 없앤다
        this.isChildStart = false;
    }
    public void CollsionChild()
    {
        Debug.Log("아이 닿음");
        mChild.GetComponent<Animator>().SetFloat("h", 0.0f);
        isChildStart = false;
    }
    public void CollisionMotorCycle()
    {
        Debug.Log("오토바이 닿음");
        isMotorCycleStart = false;
    }
    public void ExitCollisionMotorCycle()
    {
        isMotorCycleStart = true;
    }
    public void CollisionCar()
    {
        Debug.Log("차 닿음");
        isCarStart = false;
    }
    public void ExitCollisionCar()
    {
        isCarStart = true;
    }
    public void DestroyStudents()
    {
        Destroy(mPeople);
    }
}
