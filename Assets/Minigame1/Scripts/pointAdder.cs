using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointAdder : MonoBehaviour
{
    //Detta script är för att se till så att poänegen läggs till korrekt -Lukas 
    public points points;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Food") 
        { 
            points.poäng++; //Här läggs ett poäng till per collison mellan matt blocken -Lukas
            points.actualpoints = points.poäng/ 2; // Poängen delas med två efter som att den här koden kommer att avfyras från båda hållen -Lukas
            print(points.actualpoints);//OBS!!!!!!!!! BYTUT TILL EN ORDENKLIG POÄNG RÄKNARE!!!!!!!!!!!!!!!!!! -Lukas
        }
    }
}
