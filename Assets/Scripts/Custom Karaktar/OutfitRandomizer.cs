using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// mohammed
// randomizar våra kraktärs outfits från våran outfit changer

public class OutfitRandomizer : MonoBehaviour
{
    // skapar en lista med alla våra olika platser 
    public List<OutfitChanger> outfitChangers = new List<OutfitChanger>();

    // randomizar våra outfits
    public void RandomizeCharacter(){
        foreach (OutfitChanger changer in outfitChangers){
            changer.Randomize;
        }
    }
}
