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
        if (hasLanded == true)
        {
            FindObjectOfType<points>().poäng += 1;
            if (FindObjectOfType<points>().poäng % 5 == 0)
            {
                FindObjectOfType<foodDestroyer>().destroyAll();
            }
            FindObjectOfType<foodSpawner>().spawnFood();
            this.enabled = false;
        }
    }
}
