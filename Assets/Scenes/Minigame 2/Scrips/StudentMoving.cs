using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentMoving : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(-transform.up * 0.1f, ForceMode.Impulse);
    }
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.transform.tag == "Death")
        {
            Destroy(gameObject);
        }
    }
}
