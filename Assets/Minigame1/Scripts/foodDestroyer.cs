using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class foodDestroyer : MonoBehaviour
{
    List<GameObject> foodList = new List<GameObject>();
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<foodLogic>() != null)
        {
            foodList.Add(collision.gameObject);
        }
    }

    public void destroyAll()
    {
        foreach (var item in foodList)
        {
            Destroy(item);
        }
        foodList.Clear();
    }
}
