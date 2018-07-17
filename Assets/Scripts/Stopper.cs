using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stopper : MonoBehaviour
{
    private Vector3 pointA = new Vector3(2.0f, 19.44f, 0);
    private Vector3 pointB = new Vector3(-3.0f, 17.33f, 0);
    private float speed = 0.6f;
    // Use this for initialization

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(pointA, pointB, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
    }
}
