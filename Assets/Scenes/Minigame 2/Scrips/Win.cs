using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;

public class Win : MonoBehaviour
{
    //Skriven av Markus W

    public GameObject victory;
    public GameObject lose;

    public mini2Movment Health; 
    
    


    // Start is called before the first frame update
    void Start()
    {
        victory.SetActive(false);
        lose.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Health.PlayerHealth == 0)
        {
            Lose();
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Goal")
        Victory();
    }

    public void Lose()
    {
        lose.SetActive(true);

    }

    public void Victory()
    {
        Time.timeScale = 0;
        victory.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Minigame 2");
    }

    // skrivs senare
    public void ReturnToOverworld()
    {
        SceneManager.LoadScene("OverWorld");
    }
}
