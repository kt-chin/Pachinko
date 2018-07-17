using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsAndScore : MonoBehaviour {
    public Text credText;
    public static int Credits;
    public AudioSource slotBonus;
    public AudioSource jackpotBonus;
    public AudioSource fail;

    // Use this for initialization
    void Start () {
        Credits = 50;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
      //  Debug.Log(Credits);
        if (FireBalls.ballShot == true)
        {
            Credits -= 1;
        }
        if (ballScript.gutterBall)
        {
            fail.Play();
        }
        if (ballScript.Jackpot)
        {
            jackpotBonus.Play();
        }
        if (ballScript.bonusSlot)
        {
            slotBonus.Play();
        }
        credText.text = "Credits: " + Credits;
	}
}
