using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateMovment : MonoBehaviour
{
    public Rigidbody2D plate;
    public KeyCode right;
    public KeyCode left;
    //Väldigt baisc 2d rörelse kod -Lukas
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
    }
}