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
            FindObjectOfType<foodSpawner>().spawnFood();
            this.enabled = false;
        }
    }
}
