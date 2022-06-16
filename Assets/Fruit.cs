using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    //vector2.up is universal
    //transform.up is local

    Rigidbody2D rb;
    public GameObject watermelonSliced;
    public float speed = 20f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * speed, ForceMode2D.Impulse);  //speed 
        //Vector2.up and transform.up BOTH ARE CORRECT!!
        //well no. Vector2.up will always throw the ball in the upword direction,
        //regardless of the local rotation of the object
        //Whereas transform.up will always account for the local rotation of the object,
        //and will throw it in the direction of the local rotation!!
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
