using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashScript : MonoBehaviour
{
    private IEnumerator coroutine;
    private float blinkTimer = 2.0f;
    public GameObject[] objectArray;
    //public ballScript ballScriptRef;
    //private Rigidbody ballRef;
    //private Rigidbody holeRigidbody;
    private bool entryCollisionBonus1;
    private bool entryCollisionBonus2;
    private bool entryCollisionJackpot;
    private bool entryCollisionDeadzone;
    private bool coroutineRunning = false;
    public Renderer[] gameobjectRender;
    public static GameObject ballObject;
    private int i;
    // Use this for initialization
    void Start()
    {
        coroutine = blink(1.5f);
    }


    private void Update()
    {
        Debug.Log(blinkTimer);
        Debug.Log(coroutineRunning);
        entryCollisionBonus1 = ballScript.bonusSlot1;
        entryCollisionBonus2 = ballScript.bonusSlot2;
        entryCollisionJackpot = ballScript.Jackpot;
        entryCollisionDeadzone = ballScript.gutterBall;

        ////////////////////////////////////////////
        //Debug controls
        if (Input.GetKey(KeyCode.Q))
        {
            entryCollisionBonus1 = true;
            coroutineRunning = false;
        }
        if (Input.GetKey(KeyCode.W))
        {
            entryCollisionBonus2 = true;
            coroutineRunning = false;
        }
        if (Input.GetKey(KeyCode.E))
        {
            entryCollisionJackpot = true;
            coroutineRunning = false;
        }
        if (Input.GetKey(KeyCode.R))
        {
            entryCollisionDeadzone = true;
            coroutineRunning = false;
        }
        /////////////////////////////////////////////

        if(coroutineRunning)
        {
            blinkTimer -= Time.deltaTime;
            if (blinkTimer <= 0)
            {
                StopCoroutine(coroutine);
                coroutineRunning = false;
                blinkTimer = 2.0f;
            }
        }

        if (!coroutineRunning)
        {
            gameobjectRender[i].enabled = true;
            if (entryCollisionBonus1/* && coroutineRunning == false*/)
            {
                i = 0;
                StartCoroutine(coroutine);
                entryCollisionBonus1 = false;
                
            }
            if (entryCollisionBonus2 /*&& coroutineRunning == false*/)
            {
                i = 1;
                StartCoroutine(coroutine);
                entryCollisionBonus2 = false;
                //coroutineRunning = true;
            }
            if (entryCollisionJackpot /*&& coroutineRunning == false*/)
            {
                i = 2;
                StartCoroutine(coroutine);
                entryCollisionJackpot = false;
                //coroutineRunning = true;
            }
            if (entryCollisionDeadzone /*&& coroutineRunning == false*/)
            {
                i = 3;
                StartCoroutine(coroutine);
                entryCollisionDeadzone = false;
                //coroutineRunning = true;
            }
        }
       

        //if (blinkTimer <= 0)
        //{
        //    coroutineRunning = false;
        //    if (entryCollisionBonus1)
        //    {
        //        entryCollisionBonus1 = false;
        //    }
        //    if (entryCollisionBonus2)
        //    {
        //        entryCollisionBonus2 = false;
        //    }
        //    if (entryCollisionJackpot)
        //    {
        //        entryCollisionJackpot = false;
        //    }
        //    if (entryCollisionJackpot)
        //    {
        //        entryCollisionJackpot = false;
        //    }
        //    StopCoroutine(coroutine);
        //    blinkTimer = 2.0f;
        //    gameobjectRender[i].enabled = true;
        //    coroutineRunning = false;
        //}


        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    entryCollision = true;
        //}

        //if (entryCollision == true)
        //{
        //    coroutine = blink(0.1f);
        //    StartCoroutine(coroutine);
        //    entryCollision = false;
        //}
        //if (blinkTimer <= 0)
        //{
        //    entryCollision = false;
        //    StopCoroutine(coroutine);
        //    alphaRender.enabled = true;
        //    blinkTimer = 0.1f;
        //}
    }
    private IEnumerator blink(float frequency)
    {   
            for (i = 0; i < objectArray.Length; i++)
            {
                
                gameobjectRender[i] = objectArray[i].GetComponent<Renderer>();
                while (Time.deltaTime < frequency)
                {
                    coroutineRunning = true;
                  //gameObject.GetComponent<Renderer>()
                    gameobjectRender[i].enabled = false;
                    yield return new WaitForSeconds(0.1f);
                    gameobjectRender[i].enabled = true;
                    yield return new WaitForSeconds(0.1f);
                }
               
            }
        }
    }





