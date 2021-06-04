using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keepCharacter : MonoBehaviour
{
    public GameObject character;
    public List<OutfitChanger> OutfitChangers = new List<OutfitChanger>();

    public void RandomizeCharacter()
    {
        foreach (OutfitChanger changer in OutfitChangers)
        {
            changer.Randomize();
        }
    }

    public void Submit()
    {
        PrefabUtility.SaveAsPrefabAsset(character, "Assets/Tobias.prefab");
        SceneManager.LoadScene(0);
        //Skapar en prefab som sparar dina ändringar och loadar in dom i scene 0
    }
    //skriven och kodad av Leo
}
