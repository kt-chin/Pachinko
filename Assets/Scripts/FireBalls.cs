using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBalls : MonoBehaviour {
    public Rigidbody balls;
    private float ballForce;
    private float normBallForce;
    private float ballTimer = 1.0f;
    private bool fireBalls = false;
    static public bool ballShot = false;
    static public float maxSpeed;
    public static float currentForce;
    private int testCount;
    static public float speed;
    private GameObject objectrotator;
    private Vector3 ballVelocity;
    private Rigidbody BallClone;
    // private objectRotator objectrotator;
    // Use this for initialization
    void Start () {
       objectrotator = GameObject.Find("BallShooter");
    }

    void Update()
    {
        ballShot = false;

        if (Input.GetKeyUp(KeyCode.Space) && fireBalls == false)
        {
            fireBalls = true;
        }
        else if (Input.GetKeyUp(KeyCode.Space) && fireBalls == true || CreditsAndScore.Credits == 0)
        {
            fireBalls = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate() {  
        ballForce = objectrotator.GetComponent<objectRotator>().rotatedAmount.z;

        
        normBallForce = ballForce/ 90;
        if (fireBalls)
        {
            ballTimer -= Time.deltaTime;
        }

        if (ballTimer <= 0)
        {
            float randomFactor = Random.Range(0.0f, 10.0f);
            ballShot = true;
            speed = ((normBallForce * 3000.0f) + randomFactor);

            BallClone = Instantiate(balls, transform.position, transform.rotation);
            BallClone.GetComponent<Rigidbody>().AddForce(-speed, 0, 0);
            ballTimer = 2.0f;
            
        }
      //  Debug.Log(BallClone.velocity);
     //   BallClone.velocity = new Vector3(-speed, BallClone.velocity.y, BallClone.velocity.z);
    }
}
