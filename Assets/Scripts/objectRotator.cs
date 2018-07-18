using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectRotator : MonoBehaviour
{
    private float sensitivity = 1000;
    public Vector3 rotatedAmount;
    private Vector2 Mouse;
    private bool rotating;
    private float minRot = 0;
    private float maxRot = 90;
    // Use this for initialization
    void Start()
    {
        Mouse = new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //Debug.Log(rotatedAmount.z);
        rotatedAmount = transform.eulerAngles;

        //if (Input.GetMouseButton(0))
        //{
            if (Mouse.x <= transform.position.x && rotatedAmount.z >= minRot)
            {
                transform.Rotate(180, 0, Input.GetAxis("Mouse X") * Time.deltaTime * -sensitivity);
                rotatedAmount.z = Mathf.Clamp(Input.GetAxis("Mouse X") - rotatedAmount.z, minRot, maxRot);
                
            }
            if (Mouse.x >= transform.position.x && rotatedAmount.z <= maxRot)
            {
                transform.Rotate(180, 0 , Input.GetAxis("Mouse X") * Time.deltaTime * sensitivity);
                rotatedAmount.z = Mathf.Clamp(rotatedAmount.z + Input.GetAxis("Mouse X"), minRot, maxRot);
                
            }
          
                transform.eulerAngles = new Vector3(0,180,rotatedAmount.z);
       // }


    }

}

