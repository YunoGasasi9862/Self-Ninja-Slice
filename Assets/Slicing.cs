using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slicing : MonoBehaviour
{
    public bool isCutting;
    Rigidbody2D rb;
    Camera cam;
    public CircleCollider2D col;
    public GameObject bladeTrail;
    GameObject trail;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main; //thats all
        col = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Startcutting();
        }else if(Input.GetMouseButtonUp(0))
        {
            StopCutting();
        }


        if(isCutting)
        {
            UpdateCutting();
        }
    }


    void UpdateCutting()
    {
        Vector2 pos = cam.ScreenToWorldPoint(Input.mousePosition);  //SCREEN TO WORLD POINT!!
        rb.position = pos; //new position

    }

    void Startcutting()
    {
        isCutting = true;
        col.enabled = true;
        trail = Instantiate(bladeTrail, transform);
    }

    void StopCutting()
    {
        isCutting = false;
       col.enabled = false;
        trail.transform.SetParent(null); //remove the trail from the parent!
        Destroy(trail, 2); //removes that trail, not the prefab!!

    }
}
