using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class points : MonoBehaviour
{
    // En simpel poängräknare -Luaks
    public float poäng;
    public float actualpoints;
    public TMP_Text poängDisplay;
    private void Update()
    {
        poängDisplay.text = "Poäng: " + actualpoints;
    }

}
