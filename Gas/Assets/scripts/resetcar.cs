using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetcar : MonoBehaviour
{
    float elapsedtime = 0;
    CheckPoints checkPoints;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        checkPoints = GetComponent<CheckPoints>();
    }

    private void Update()
    {
        if(rb.velocity.magnitude<=1)
        {
            elapsedtime = elapsedtime + Time.deltaTime;
        }
        else
        {
            elapsedtime = 0;
        }
        if(elapsedtime>5)
        {
            gameObject.transform.position = checkPoints.PrevCheckPoint.transform.position;
        }
    }
}
