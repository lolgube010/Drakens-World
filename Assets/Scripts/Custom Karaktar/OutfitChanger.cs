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
    [Header("Kroppsdel vi ska byta")]
    public SpriteRenderer bodyPart;

    // alla våra nya sprites
    [Header("Alla våra olika sprites för kroppsdelen ovan")]
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
        if(currentOption < 0){
            currentOption = options.Count - 1; // resettar våran lista om man kommer till slutet
        }
        
        bodyPart.sprite = options[currentOption];
    }

    // sätter våran sprite till någon random från listan
    // if our randomize system skips the last bodypart, remove the -1 in the random.range
    public void Randomize(){
        currentOption = Random.Range(0, options.Count);
        bodyPart.sprite = options[currentOption];
    }

}
