using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//detta script är för att få logiken för spelet att va klara - Lukas
public class foodLogic : MonoBehaviour
{
    bool hasLanded;
    public points points;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        hasLanded = true;
    }
    private void Start()
    {
        points = FindObjectOfType<points>();
    }
    private void Update()
    {
        if (hasLanded == true) //När objektet landar ska objektet lägga till ett poäng och om det är en stack av 5 så tar den bort all mat från scenen.
        {
            points.poäng += 1;
            if (points.poäng == 5)
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
