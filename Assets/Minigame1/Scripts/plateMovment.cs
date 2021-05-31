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
    
    void Update()
    {
        StartCoroutine("Accelerate");
        if (Input.GetKey(right))
        {
            
            //plate.AddForce(new Vector2(2, 0));// för att åka höger -Lukas
        }
        if (Input.GetKey(left))
        {
            //plate.AddForce(new Vector2 (-2,0)); // för att åk avänster -Lukas 
        }
    }
    public float speed;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.velocity = Vector2.right * speed;
    }

    IEnumerator Accelerate()
    {
        if (Input.GetKeyDown(right))
        {
            for (float i = speed; i < 4; i += 0.5f)
            {
                speed = i;
                yield return new WaitForSeconds(.1f);
            }
        }
        else if (Input.GetKeyDown(left))
        {
            for (float i = speed; i > -4; i -= 0.5f)
            {
                speed = i;
                yield return new WaitForSeconds(.1f);
            }
        }
        else
        {
            if (speed >= 0)
            {
                for (float i = speed; i == 0; i -= 0.5f)
                    {
                        speed = i;
                        yield return new WaitForSeconds(.1f);
                    }
            }
            else
            {
                for (float i = speed; i == 0; i -= 0.5f)
                {
                    speed = i;
                    yield return new WaitForSeconds(.1f);
                }
            }

        }
    }
}