using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{


    Rigidbody2D rb;
    public GameObject watermelonSliced;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Blade")
        {
            Vector3 direction = (collision.transform.position - transform.position).normalized;
            Quaternion rotation = Quaternion.LookRotation(direction);
            GameObject sliced = Instantiate(watermelonSliced, transform.position, rotation);
            Destroy(sliced, 3f);
            Destroy(gameObject);


        }
    }
}
