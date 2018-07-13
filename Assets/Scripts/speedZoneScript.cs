using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedZoneScript : MonoBehaviour {
    public int speedZonePass = 0;
    public GameObject[] speedZones;
    public int speedZoneObject;
    public static float copiedForce;
    public bool szBoolleft = false;
    public bool szBoolright = false;
    public bool szBoolUp1 = false;
    public bool szBoolDown = false;
    public bool szBoolUp2 = false;
    // Use this for initialization
    void Start () {
		
	}

    private void OnTriggerEnter(Collider ballEnter)
    {
        if (ballEnter.gameObject.tag == "Ball" && ballScript.speedZoneActivate == true)
        {
            copiedForce = FireBalls.speed;
            Debug.Log("Hit");
           // speedZonePass += 1;
        }
    }

    // Update is called once per frame
    void Update () {
	//if (speedZonePass == 5)
 //       {
 //           speedZonePass = 0;
 //       }
        //for (int i=0; i < speedZones.Length; i++)
        //{
        //    if (speedZones[i])
        //    {
        //        if ()
        //    }
        //}
	}
}
