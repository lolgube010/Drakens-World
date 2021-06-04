using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuTimeStop : MonoBehaviour
{
    public AudioClip[] Död;
    int RandomSound;
    public AudioSource Audio;
    // Start is called before the first frame update
    void Start()
    {
        Död = Resources.LoadAll<AudioClip>("Sounds/Tobias/Start");
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startTime()
    {
        if (!Audio.isPlaying)
        {
            Audio.clip = Död[RandomSound];
            Audio.Play();
  
        }
        Time.timeScale = 1;
    }
}
