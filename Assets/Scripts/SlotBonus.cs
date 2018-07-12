using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotBonus : MonoBehaviour {
    private Vector3 pointA = new Vector3(-2.3f, 0.3f, -0.2f);
    private Vector3 pointB = new Vector3(4.3f, 0.3f , -0.2f);
    private float speed = 1.0f;
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
