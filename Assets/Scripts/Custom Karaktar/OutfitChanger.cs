using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// skriven av mohammed
// låter oss byta outfit i dem olika delarna

public class OutfitChanger : MonoBehaviour
{
    // dra script till varje kroppsdel
    // sedan dra in alla sprites för den kroppsdelen i 
    // listan under

    // spriterender för varje kroppsdel
    public SpriteRenderer bodyPart;

    // alla våra sprites
    public List<Sprite> options = new List<Sprite>();

    private int currentOption = 0;

    // väljer nästa klädsel
    public void NextOption(){
        currentOption++;
        if(currentOption >= options.Count){
            currentOption = 0; // resettar våran lista om man kommer till slutet
        }
        bodyPart.sprite = options[currentOption];
    }

    // väljer tidigare klädsel
    public void PreviousOption(){
        currentOption--;
        if(currentOption <= 0){
            currentOption = options.Count - 1; // resettar våran lista om man kommer till slutet
        }
        
        bodyPart.sprite = options[currentOption];
    }

    // sätter våran sprite till någon random från listan
    public void Randomize(){
        currentOption = Random.Range(0, options.Count - 1);
        bodyPart.sprite = options[currentOption];
    }

}
