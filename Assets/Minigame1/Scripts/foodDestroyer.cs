using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;
//koden är för att förstöra food blocken när det når fem styck på talricken -Lukas
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

    IEnumerator destroyAll() //En funktion för att förstöra alla objekt med en delay på en sekund.
    {
        yield return new WaitForSeconds(1f);
        foreach (var item in foodList)
        {
            Destroy(item);
        }
        FindObjectOfType<points>().actualpoints++; //Lägger till ett poäng.
        foodList.Clear();
        FindObjectOfType<points>().poäng = 0; //Resettar referens countern.
        FindObjectOfType<foodSpawner>().spawnFood(); //Skapar mer mat efter att maten är borta
        yield return null;
    }
}
