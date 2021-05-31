using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

// mohammed
// randomizar våra kraktärs outfits från våran outfit changer

public class OutfitRandomizer : MonoBehaviour
{
    public GameObject character;
    // skapar en lista med alla våra olika platser 
    [Header("Kroppsdelar vi ska randomiza")]
    public List<OutfitChanger> outfitChangers = new List<OutfitChanger>();

    // randomizar våra outfits för varje kroppsdel
    public void RandomizeCharacter(){
        foreach (OutfitChanger changer in outfitChangers){
            changer.Randomize();
        }
    }

// this is where we save our player prefab
    public void Submit(){
        PrefabUtility.SaveAsPrefabAsset(character, "Assets/Saves/Player.prefab");
    }

}
