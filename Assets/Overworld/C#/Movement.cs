using System.Collections;

using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    // Start is called before the first frame update

    public float moveSpeed = 7f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Animator anm;
    private Vector2 velocity;
    public float currentSpeed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        anm.SetFloat("Horizontal", movement.x);
        anm.SetFloat("Vertical", movement.y);
        anm.SetFloat("Speed", movement.sqrMagnitude);
     
    }

    private void FixedUpdate()
    {
        /* denna line tar spelarens position och lägger till movement vilket är i update getAxisraw vilket ger ett värde mellan -1 och 1,
        det värdet bestämer vilket håll på den axis som spelaren rör sig.
        sedan multipliseras det med move spedd som kontrollerar hastigheten av spelaren.*/

        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}