using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMovement : MonoBehaviour
{
    Vector2 move;
    [SerializeField] float strength = 100f;

    Rigidbody rb;
   
    void Start()
    {
        Cursor.lockState  = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 move = new Vector3 (Input.GetAxis("Mouse X") , Input.GetAxis("Mouse Y"), 0);

        if(move.x != 0)
        {
            rb.AddForceAtPosition(move * strength, transform.localPosition, ForceMode.Force);
        }

        else if(move.y != 0)
        {
            rb.AddForceAtPosition(move * strength, transform.localPosition, ForceMode.Force);
        }
        else rb.AddForce(0,0,0);


    }
}
