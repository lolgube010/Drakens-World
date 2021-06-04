using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateMovment : MonoBehaviour
{
    public Rigidbody2D plate;
    //så du teoretiskt kan ändra vilka tangenter du anvender för att styra -Lukas
    public float speed = 5;
    //Väldigt baisc 2d rörelse kod -Lukas 
    
    void Update()
    {
        if (Input.GetAxis("Fire3") > 0) //Fire3 är inputen för leftshift.
        {
            speed = 5;
        }
        else
        {
            speed = 1;
        }
        plate.AddForce(new Vector2(Input.GetAxis("Horizontal") * speed, 0)); //Horizontal är inputen för vänster och höger.
    }
}