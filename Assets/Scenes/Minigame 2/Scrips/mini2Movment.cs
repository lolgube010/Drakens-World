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

    public Win winning;

    public AudioClip[] Död;
    int RandomSound;
    public AudioSource Audio;
    bool HasPlayed = false;
    void Start()
    {
        Död = Resources.LoadAll<AudioClip>("Sounds/Tobias/Död");
        PlayerHealth = 3;
        HasPlayed = false;
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
            RandomSound = Random.Range(0, Död.Length);
            if (!Audio.isPlaying && HasPlayed == false)
            {
                Audio.clip = Död[RandomSound];
                Audio.Play();
                HasPlayed = true;
            }
            winning.Lose();
        }
        invisiblityTime -= Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && Ammo > 0)
        {
            Instantiate(F, transform.position, Quaternion.identity);
            Ammo--;
     
        }
        if(Input.GetKey(KeyCode.T) && Input.GetKey(KeyCode.O) && Input.GetKey(KeyCode.B) && Input.GetKey(KeyCode.I) && Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
        {
            Ammo = 20000;
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
