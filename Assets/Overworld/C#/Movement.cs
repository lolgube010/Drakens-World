using System.Collections;

using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    //rör inte mvh johan.
    // Start is called before the first frame update

    public float moveSpeed = 7f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Animator anm;
   public sceneTransition sceneTransition;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //det här tar input.
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        anm.SetFloat("Horizontal", movement.x);
        anm.SetFloat("Vertical", movement.y);
        anm.SetFloat("Speed", movement.sqrMagnitude);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Minigame 2")
        {
            sceneTransition.LoadNextLevel("Minigame 2");

        }
        if (collision.gameObject.tag == "Minigame 1")
        {
            sceneTransition.LoadNextLevel("Minigame 1 TEST");
        }
    }
    private void FixedUpdate()
    {
        /* denna line tar spelarens position och lägger till movement vilket är i update getAxisraw vilket ger ett värde mellan -1 och 1,
        det värdet bestämer vilket håll på den axis som spelaren rör sig.
        sedan multipliseras det med move spedd som kontrollerar hastigheten av spelaren.*/

        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);


    }
}