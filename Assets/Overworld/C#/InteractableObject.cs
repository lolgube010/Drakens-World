using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public Camera cam;//läg in main camera-Alfred
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//om man klickar på vänster mus-Alfred
        {
            RaycastHit2D hit = Physics2D.Raycast(cam.ScreenToWorldPoint(Input.mousePosition),Vector2.zero);//skapar en raycast  från kameran där musen är utan någon vinkel-Alfred

            if (hit.transform != null && hit.collider.tag == "Object")//om raycasten träffar något och det objectet har tagen "Object"-Alfred
            { 
                Animator anm = hit.collider.gameObject.GetComponent<Animator>();//hämtar objectet man träffars animator-Alfred
                anm.SetTrigger("trigger");//sätter igång animationen med en parameter-Alfred
            }
        }
    }

}
