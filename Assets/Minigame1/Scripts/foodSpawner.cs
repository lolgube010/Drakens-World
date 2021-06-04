using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//scriptet för att starta spelet & spawna food consistantally -Lukas
public class foodSpawner : MonoBehaviour
{
    public GameObject foodPrefab;
    Vector3 spawnOffset;
    public UnityEngine.UI.Text startInfo;
    bool hasStarted;
    public points points;

    public GameObject[] foodParts;
    private void Update()
    {
        if (Input.GetAxis("Jump") > 0 && hasStarted != true) //Skapar en mat när man startar spelet och trycker på space.
        {
            spawnFood();
            startInfo.enabled = false;
            hasStarted = true;
        }
        print(Random.Range(4, 1));
    }
    public void spawnFood() //Skapar mat med en slumpad x position.
    {
        spawnOffset = gameObject.transform.position;
        spawnOffset.x += Random.Range(2f, -3f);
        

        points = FindObjectOfType<points>();
        if (points.poäng == 0)
        {
            Instantiate(foodParts[0], spawnOffset, Quaternion.identity);
        }
        else if (points.poäng == 5)
        {
            Instantiate(foodParts[4], spawnOffset, Quaternion.identity);
        }
        else
        {
            Instantiate(foodParts[Random.Range(4, 1)], spawnOffset, Quaternion.identity);
        }
    }
}
