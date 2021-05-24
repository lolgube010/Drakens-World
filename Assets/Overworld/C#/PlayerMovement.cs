using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class PlayerMovement : MonoBehaviour
{
    [Header("Player")]
    public Rigidbody2D rb;
    [SerializeField, Range(0, 10)]
    float moveSpeed;
    private Vector2 movement;
    private Vector2 currentVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = currentVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Up"))
        {
         rb.velocity = new Vector2(currentVelocity.x,moveSpeed);

        }
        if(Input.GetButtonDown("Down"))
        {
            rb.velocity = new Vector2(currentVelocity.x, -moveSpeed);
        }
        if(Input.GetButtonDown("Left"))
        {
            rb.velocity = new Vector2(moveSpeed, currentVelocity.y);

        }
        if(Input.GetButtonDown("Right"))
        {
            rb.velocity = new Vector2(-moveSpeed, currentVelocity.y);
        }
    }
}
