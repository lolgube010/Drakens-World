using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mini2Movment : MonoBehaviour
{
    public float movmentSpeed;
    public Rigidbody2D rb;
    Vector2 movment;
    public int PlayerHealth;
    public float invisiblityTime;
    public GameObject[] hearts;

    public GameObject F;
    public int Ammo;

    void Start()
    {
        PlayerHealth = 3;
    }
    private void FixedUpdate() 
    {
        rb.velocity = new Vector2(movment.x * movmentSpeed , movment.y * movmentSpeed); // flytar spelaren baserat på input och movement speed - Bo
   
    }

    void Update()
    { // hämtar spelarens input - Bo
        movment.x = Input.GetAxisRaw("Horizontal");
        movment.y = Input.GetAxisRaw("Vertical");
        if (PlayerHealth <= 0)
        {
            Destroy(gameObject);
        }
        invisiblityTime -= Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && Ammo > 0)
        {
            Instantiate(F, transform.position, Quaternion.identity);
            Ammo--;
     
        }
    }
    public void updateHearts()
    {
        foreach(GameObject heart in hearts)
        {
            if(PlayerHealth - 1< System.Array.IndexOf(hearts, heart))
            {
                heart.SetActive(false);
            }
        }
    }
}
