using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Win : MonoBehaviour
{
    //Sriven av Markus W

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
        //Behöver ett sätt att vinna
        //if ()
        //{
            //Victory();
        //}


        if (Health.PlayerHealth == 0)
        {
            Lose();
        }

    }


    public void Lose()
    {
        lose.SetActive(true);
    }

    public void Victory()
    {
        victory.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Markus");
    }

    // skrivs senare
    public void ReturnToOverworld()
    {

    }
}
