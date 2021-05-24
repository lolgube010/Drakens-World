using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mini2Movment : MonoBehaviour
{
    public float movmentSpeed;
    public Rigidbody2D rb;
    Vector2 movment;

    void Start()
    {
        
    }
    private void FixedUpdate() 
    {
        rb.velocity = new Vector2(movment.x * movmentSpeed , movment.y * movmentSpeed); // flytar spelaren baserat på input och movement speed - Bo

    }

    void Update()
    { // hämtar spelarens input - Bo
        movment.x = Input.GetAxisRaw("Horizontal");
        movment.y = Input.GetAxisRaw("Vertical");
    }
}
