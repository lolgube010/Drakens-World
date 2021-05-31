using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodLogic : MonoBehaviour
{
    bool hasLanded;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        hasLanded = true;
    }
    private void Update()
    {
        if (hasLanded == true) //När objektet landar ska objektet lägga till ett poäng och om det är en stack av 5 så tar den bort all mat från scenen.
        {
            FindObjectOfType<points>().poäng += 1;
            if (FindObjectOfType<points>().poäng % 5 == 0)
            {
                FindObjectOfType<foodDestroyer>().StartCoroutine("destroyAll");
            }
            else
            {
                FindObjectOfType<foodSpawner>().spawnFood(); //Skapar mat mer mat om det inte finns en hög av 5 mat.
            }
            this.enabled = false;
        }
    }
}
