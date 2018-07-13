using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sdDOWN : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    private void OnTriggerEnter(Collider ballCollide)
    {
        if (ballCollide.gameObject.tag == "Ball")
        {
            ballCollide.gameObject.GetComponent<Rigidbody>().AddForce(0, speedZoneScript.copiedForce, 0);

        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
