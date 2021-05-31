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

    IEnumerator destroyAll()
    {
        yield return new WaitForSeconds(1f);
        foreach (var item in foodList)
        {
            Destroy(item);
        }
        FindObjectOfType<points>().actualpoints++;
        foodList.Clear();
        yield return null;
    }
}
