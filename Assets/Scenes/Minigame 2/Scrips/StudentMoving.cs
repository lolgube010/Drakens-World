using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Edvin
public class StudentMoving : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform Explosion;
    public mini2Movment mini;

    public AudioClip[] DödarElev;
    int RandomSound;
    public AudioSource Audio;
    public int DontPlay;

    public AudioClip[] TarSkada;
    // Start is called before the first frame update
    void Start()
    {
        mini = GameObject.FindGameObjectWithTag("Player").GetComponent<mini2Movment>();
        DödarElev = Resources.LoadAll<AudioClip>("Sounds/Tobias/DödarElev");
        TarSkada = Resources.LoadAll<AudioClip>("Sounds/Tobias/Skada");
        Audio = GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>();
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
        if(collision.tag == "Player" && mini.invisiblityTime < 0)
        {
            Destroy(gameObject);
            Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y, -4), Quaternion.identity);
            mini.PlayerHealth -= 1;
            mini.invisiblityTime = 0.5f;
            mini.updateHearts();

            RandomSound = Random.Range(0, DödarElev.Length);
      
            if (!Audio.isPlaying)
            {
                Audio.clip = TarSkada[RandomSound];
                Audio.Play();
            }
        }
        if(collision.tag == "F")
        {
            RandomSound = Random.Range(0, DödarElev.Length);
            DontPlay = Random.Range(0, 4);
         
            if (!Audio.isPlaying && DontPlay > 1)
            {
                Audio.clip = DödarElev[RandomSound];
                Audio.Play();
            }
   
            Destroy(gameObject);
            Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y, -4), Quaternion.identity);
            collision.gameObject.GetComponent<BulletBehaviour>().Durability--;
        }
    }
 
}
