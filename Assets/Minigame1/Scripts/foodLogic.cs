using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodLogic : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<foodSpawner>().spawnFood();
        this.enabled = false;
    }
}
