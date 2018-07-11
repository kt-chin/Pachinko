using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBalls : MonoBehaviour {
    public Rigidbody balls;
    private float ballForce;
    private float normBallForce;
    private float ballTimer = 1.0f;
    private bool fireBalls = false;

    private objectRotator objectrotator;
	// Use this for initialization
	void Start () {
        
    }



    // Update is called once per frame
    void Update() {
        GameObject objectrotator = GameObject.Find("BallShooter");
        ballForce = objectrotator.GetComponent<objectRotator>().rotatedAmount.z;
        //objectrotator.gameObject.transform.rotation.z;;
        if (Input.GetKeyUp(KeyCode.Space) && fireBalls == false)
        {
            fireBalls = true;
        }
        else if (Input.GetKeyUp(KeyCode.Space) && fireBalls == true)
        {
            fireBalls = false;        
        }

        normBallForce = ballForce/ 90;
        if (fireBalls)
        {
            ballTimer -= Time.deltaTime;
        }

        if (ballTimer < 0)
        {
            Rigidbody BallClone;
            BallClone = Instantiate(balls, transform.position, transform.rotation);
            BallClone.AddForce(0, normBallForce* 150, 0);
            ballTimer = 2.0f;
        }
	}
}
