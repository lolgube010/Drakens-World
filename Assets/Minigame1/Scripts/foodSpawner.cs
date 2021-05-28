using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodSpawner : MonoBehaviour
{
    public GameObject foodPrefab;
    Vector3 spawnOffset;
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spawnFood();
        }
    }
    public void spawnFood()
    {
        spawnOffset = gameObject.transform.position;
        spawnOffset.x += Random.Range(2f, -3f);
        Instantiate(foodPrefab, spawnOffset, Quaternion.identity);
    }
}
