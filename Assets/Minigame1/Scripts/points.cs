using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class points : MonoBehaviour
{
    // En simpel poängräknare -Luaks
    public float poäng;
    public float actualpoints;
    public TMP_Text poängDisplay;
    public sceneTransition scene;
    private void Update()
    {
        poängDisplay.text = "Poäng: " + actualpoints;

        if (actualpoints >= 2f) { scene.LoadNextLevel("OverWorld"); }//du vinner vi tio poäng -Lukas
    }


}
