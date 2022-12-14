using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1,0,0,1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] float destroyDelay = 0.5f;

    bool hasPackage;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("oush!!!");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package" && !hasPackage)
        {
            spriteRenderer.color = hasPackageColor;
            Destroy(collision.gameObject, destroyDelay);
            hasPackage = true;
        }

        if (collision.tag == "Customer" && hasPackage)
        {
            spriteRenderer.color = noPackageColor;
            Debug.Log("Package delivered");
            hasPackage = false;
        }
    }
}