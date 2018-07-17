using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holeForce : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    private void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "Ball")
        {
            collider.gameObject.GetComponent<Rigidbody>().AddForce(0, 0, 7.2f);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
