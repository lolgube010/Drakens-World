using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateMovment : MonoBehaviour
{
    public Rigidbody2D plate;
    //så du teoretiskt kan ändra vilka tangenter du anvender för att styra -Lukas
    public KeyCode right;
    public KeyCode left;
    //Väldigt baisc 2d rörelse kod -Lukas 
    /*
    void Update()
    {
        if (Input.GetKey(right))
        {
            plate.AddForce(new Vector2(2, 0));// för att åka höger -Lukas
        }
        if (Input.GetKey(left))
        {
            plate.AddForce(new Vector2 (-2,0)); // för att åk avänster -Lukas 
        }
    }*/
    public float speed = 10f;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.velocity = Vector2.right * speed;
    }
}