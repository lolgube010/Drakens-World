using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//To make a custom class appear in the inspector you have to serialize it. 
[System.Serializable]
public class Sound : MonoBehaviour
{
    //Add a name to the clip.
    public string names;

    //You're able to add a clip to the script...
    public AudioClip clip;

    //Range = Adds sliders to whatever i'm putting it on.
    //...and change it's volume and pitch.
    [Range(0f, 1f)]
    public float volume;

    [Range(.1f, 3f)]
    public float pitch;

    //HideInInspector = Like it sounds, it hides the code so it's invisible in the inspector even though it's public.
    [HideInInspector]
    public AudioSource source;
}
