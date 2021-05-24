﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

// mohammed
// randomizar våra kraktärs outfits från våran outfit changer

public class OutfitRandomizer : MonoBehaviour
{
    public GameObject character;
    // skapar en lista med alla våra olika platser 
    public List<OutfitChanger> outfitChangers = new List<OutfitChanger>();

    // randomizar våra outfits
    public void RandomizeCharacter(){
        foreach (OutfitChanger changer in outfitChangers){
            changer.Randomize();
        }
    }

    public void Submit(){
        PrefabUtility.SaveAsPrefabAsset(character, "Assets/Saves/Player.prefab");
    }

}
