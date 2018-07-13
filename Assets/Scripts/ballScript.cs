using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour {
    public static bool speedZoneActivate = false;
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
        if (collision.gameObject.tag == "sz1")
        {
            speedZoneActivate = true;
        }
    }

    // Update is called once per frame
    void Update () {
        speedZoneActivate = false;
	}
}
