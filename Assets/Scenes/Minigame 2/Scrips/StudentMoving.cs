using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Edvin
public class StudentMoving : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform Explosion;
    public mini2Movment mini;

    // Start is called before the first frame update
    void Start()
    {
        mini = GameObject.FindGameObjectWithTag("Player").GetComponent<mini2Movment>();

    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(-transform.up * 0.1f);
     
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Death")
        {
            Destroy(gameObject);
        }
        if(collision.tag == "Player")
        {
            Destroy(gameObject);
            Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y, -4), Quaternion.identity);
            mini.PlayerHealth -= 1;
        }
    }
 
}
