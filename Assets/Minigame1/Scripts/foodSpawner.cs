using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodSpawner : MonoBehaviour
{
    public GameObject foodPrefab;
    Vector3 spawnOffset;
    public UnityEngine.UI.Text startInfo;
    bool hasStarted;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && hasStarted != true)
        {
            spawnFood();
            startInfo.enabled = false;
            hasStarted = true;
        }
    }
    public void spawnFood()
    {
        spawnOffset = gameObject.transform.position;
        spawnOffset.x += Random.Range(2f, -3f);
        Instantiate(foodPrefab, spawnOffset, Quaternion.identity);
    }
}
