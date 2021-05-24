using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodDeath : MonoBehaviour
{
    public GameObject food;
    // detta script är för att föstöra mat objecten 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "DeathZone")
        {
            Destroy(food);
        }
    }
}
