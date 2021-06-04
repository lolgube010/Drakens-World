using UnityEngine.Audio;
using UnityEngine;

//Serialization = The process of transforming data structures/objects from scripts into a format that Unity can store. To put it simply, translating data to a form that Unity "understands".
//The MonoBehaviour class is automatically serializable, but our custom class isn't, therefore we need to make it serializable. That's why we write...
[System.Serializable]

//MonoBehaviour = The base class that all unity scripts derive from.
//We want to create our own class called "Sound" and to do that all we have to do is erase the "MonoBehaviour" text that's beside the script name.
//And because "MonoBehaviour" is what controlls "void Update" and "void Start" they wont be of any use to us now either.
public class Sound 
{
    public Clipnames name;
    public enum Clipnames { BullethellMusic, FishingMusic, FoodMusic, OverworldMusic, OuchSFX, RunSFX, };

    //We want to reference "AudioClip" to get a audio clip and...
    public AudioClip clip;

    //...we can add volume and pitch to the clip of our choosing.
    [Range(0f, 1f)]
    public float volume;

    //Range = Gives you the chance to put a minimum and maximum worth on a float.
    [Range(.1f, 3f)]
    public float pitch;

    //We're making an audio source so every audioclip in the array has an audio source and is therefore able to actually produce sound lmao.
    //HideInInspector = Hides your line of code so it doesnt show up in the Unity inspector, despite it being public.
    [HideInInspector]
    public AudioSource source;
}
