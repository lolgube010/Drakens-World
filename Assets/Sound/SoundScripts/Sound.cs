using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//When creating a custom class you have to mark it as serializable to have it appear in the inspector.
[System.Serializable]
public class Sound : MonoBehaviour
{
    //You can add a clip to the script from untiy...
    public AudioClip clip;

    //...and you'll be able to change volume and pitch of that clip.
    public float volume;
    public float pitch;
}
