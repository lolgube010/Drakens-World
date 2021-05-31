using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Timers;

public class foodDeath : MonoBehaviour
{
    public GameObject food;
    // detta script är för att föstöra mat objecten 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "DeathZone")// kollar om objectet är i DeathZone -Lukas
        {
            Destroy(food);// Förstör objectet
            print("Gameover");
            SceneManager.LoadScene("Minigame 1 TEST");// startar om spelet -Lukas
        }
    }
}
