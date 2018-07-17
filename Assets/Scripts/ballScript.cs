using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour {
    public static Vector3 velocity;
    private float autoDestructTimer = 4.0f;
    private bool refund = true;
    private float timer;
    // Use this for initialization
    void Start () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Killzone")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Slot")
        {
            CreditsAndScore.Credits += 5;
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Jackpot")
        {
            CreditsAndScore.Credits += 100;
            Destroy(gameObject);
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
                Destroy(gameObject);
            }
            if (refund == false)
            {
                autoDestructTimer = 4.0f;
            }
           // Debug.Log(autoDestructTimer);
        }
    }
}
