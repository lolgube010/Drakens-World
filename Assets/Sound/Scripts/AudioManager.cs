using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //Our other script and custom class called "Sound" makes an audioclip with volume, pitch and a name for it. Here we're making an array for that script.
    public Sound[] sounds;

    // Start is called right when the first frame is about to run. "Awake" is like start but it's called right before the first frame.
    void Awake()
    {
        //For each element in the array (we're nicknaming it s)...
        foreach (Sound s in sounds)
        {
            //...we're adding an AudioSource...
            //...and we're putting it in a variable.
            s.source = gameObject.AddComponent<AudioSource>();

            //Here we're basically connecting the clip, volume and pitch to the AudioSource of this element.
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    //Here we're making our own custom void called "Play" and it's gonna ask us to "Play" a string called name. So we're basically gonna name the thing we wanna "Play".
    public void Play (string name)
    {

    }
}
