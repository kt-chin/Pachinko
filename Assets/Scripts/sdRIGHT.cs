using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sdRIGHT : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    private void OnTriggerEnter(Collider ballCollide)
    {
        if (ballCollide.gameObject.tag == "Ball")
        {
            ballCollide.gameObject.GetComponent<Rigidbody>().AddForce(speedZoneScript.copiedForce, 0, 0);

        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
