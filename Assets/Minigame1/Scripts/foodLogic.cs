using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//detta script är för att få logiken för spelet att va klara - Lukas
public class foodLogic : MonoBehaviour
{
    bool hasLanded;
    public Sprite[] foodParts;
    public points points;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        hasLanded = true;
    }
    private void Start()
    {
        points = FindObjectOfType<points>();
        if (points.poäng == 0)
        {
            GetComponent<SpriteRenderer>().sprite = foodParts[0];
        }
        else if (points.poäng == 5)
        {
            GetComponent<SpriteRenderer>().sprite = foodParts[5];
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = foodParts[Random.Range(5, 1)];
        }
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
