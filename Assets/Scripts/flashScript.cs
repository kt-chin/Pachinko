using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashScript : MonoBehaviour
{
    private IEnumerator coroutine;
    private float blinkTimer = 2.0f;
    public GameObject[] objectArray;
    private bool entryCollision = false;
    // Use this for initialization
    void Start()
    {


        //Renderer r = gameObject.GetComponent<Renderer>();
        //Color materialColour = r.material.color;
        //r.material.color = new Color(materialColour.r, materialColour.g, materialColour.b,)
        // - After 0 seconds, prints "Starting 0.0"
        // - After 0 seconds, prints "Before WaitAndPrint Finishes 0.0"
        // - After 2 seconds, prints "WaitAndPrint 2.0"
       // print("Starting " + Time.time);

        // Start function WaitAndPrint as a coroutine.

        coroutine = blink(2.0f);
        StartCoroutine(coroutine);

    }

    private IEnumerator blink(float waitTime)
    {
        if (entryCollision == true)
        {
            while (Time.deltaTime < waitTime)
            {
                gameObject.GetComponent<Renderer>().enabled = false;
                yield return new WaitForSeconds(0.2f);
                gameObject.GetComponent<Renderer>().enabled = true;
                yield return new WaitForSeconds(0.2f);
            }
        }
    }
}
