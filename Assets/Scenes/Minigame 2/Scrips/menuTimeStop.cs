using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuTimeStop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startTime()
    {
        Time.timeScale = 1;
    }
}
