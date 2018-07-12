using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsAndScore : MonoBehaviour {

    static public int Credits;
    private int Bonus;
	// Use this for initialization
	void Start () {
        Credits = 40;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(Credits);
        if (FireBalls.ballShot == true)
        {
            Credits -= 1;
        }
	}
}
