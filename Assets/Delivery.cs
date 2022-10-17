using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
  
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("oush!!!");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package")
        {
            Debug.Log("Package picke up");
        }

        if (collision.tag == "Customer")
        {
            Debug.Log("Package delivered");
        }
    }
}