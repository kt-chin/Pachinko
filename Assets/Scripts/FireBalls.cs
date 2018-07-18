using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class FireBalls : MonoBehaviour {
    public GameObject ballsObject;

    private float ballForce;
    private float normBallForce;
    private float ballTimer = 1.0f;
    private bool fireBalls = false;
    static public bool ballShot = false;
    static public float speed;
    private GameObject objectrotator;
    private Vector3 ballVelocity;
   // private Rigidbody BallClone;
    public AudioSource audio;
    // private objectRotator objectrotator;
    // Use this for initialization
    void Start () {
       objectrotator = GameObject.Find("BallShooter");
       audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        

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

        ballShot = false;
        normBallForce = ballForce/ 90;
        if (fireBalls)
        {
            ballTimer -= Time.deltaTime;
        }

        if (ballTimer <= 0)
        {
            float randomFactor = Random.Range(0.0f, 10.0f);
            ballShot = true;
            speed = ((normBallForce * 2700.0f) + randomFactor);
            //BallClone = Instantiate(balls, transform.position, transform.rotation);
            ballsObject = ballPooler.sharedInstance.GetPooledBall();
            
            if (ballsObject != null)
            {
                ballsObject.transform.position = transform.position;
                ballsObject.transform.rotation = transform.rotation;
                ballsObject.SetActive(true);
            }
            //delete above for pool if not working!   
            ballsObject.GetComponent<Rigidbody>().AddForce(-speed, 0, 0);
            ballTimer = 2.0f;
            audio.Play();
            
        }
      //  Debug.Log(BallClone.velocity);
     //   BallClone.velocity = new Vector3(-speed, BallClone.velocity.y, BallClone.velocity.z);
    }
}
