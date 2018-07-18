using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ballScript : MonoBehaviour {
    public static Vector3 velocity;
    private float autoDestructTimer = 3.0f;
    private bool refund = true;
    public bool inPlay = false;
    private float timer;
    public static bool gutterBall = false;
    public static bool bonusSlot = false;
    public static bool Jackpot = false;
    // Use this for initialization
    void Start () {
	}

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Killzone")
        {
            gutterBall = true;
            gameObject.transform.position = Vector3.zero;
            gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "Slot")
        {
            CreditsAndScore.Credits += 5;
            bonusSlot = true;
            gameObject.transform.position = Vector3.zero;
            gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "Jackpot")
        {
            CreditsAndScore.Credits += 100;
            Jackpot = true;
            gameObject.transform.position = Vector3.zero;
            gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "refundZone")
        {
            CreditsAndScore.Credits += 1;
            gameObject.transform.position = Vector3.zero;
            gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "Ball" && inPlay == false)
        {
            refund = false;
            CreditsAndScore.Credits += 1;
            gameObject.transform.position = Vector3.zero;
            //collision.gameObject.transform.position = Vector3.zero;
            //collision.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
        if (inPlay == true && !gameObject.activeSelf)
        {
            inPlay = false;
            refund = true;
        }

    }
        
    

    private void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject.tag == "speedZoneCheck")
        {
            autoDestructTimer = 4.0f;
        }
        if (trigger.gameObject.tag == "speedZone")
        {
            refund = false;
            inPlay = true;
        }
    }
    private void OnTriggerStay(Collider deletion)
    {
        if (deletion.gameObject.tag == "deadZone")
        {
            refund = true;
        }
    }

    // Update is called once per frame
    void FixedUpdate () {
        if (refund==true)
        {
            autoDestructTimer -= Time.deltaTime;
            if (autoDestructTimer <= 0.0f)
            {
                CreditsAndScore.Credits += 1;
                gameObject.SetActive(false);
                gameObject.transform.position = Vector3.zero;
                refund = false;
            }
            if (refund == false)
            {
                autoDestructTimer = 3.0f;
            }
           // Debug.Log(autoDestructTimer);
        }
    }
}
