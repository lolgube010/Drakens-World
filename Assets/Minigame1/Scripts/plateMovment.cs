using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateMovment : MonoBehaviour
{
    public Rigidbody2D plate;
    public KeyCode right;
    public KeyCode left;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(right))
        {
            plate.AddForce(new Vector2(2, 0));
        }
        if (Input.GetKey(left))
        {
            plate.AddForce(new Vector2 (-2,0));
        }
    }
}