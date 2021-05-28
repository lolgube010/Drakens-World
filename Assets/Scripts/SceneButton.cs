using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// by mohammed
// loads scene A, has no transitions or anything whatsoever and is pretty simple. 
// no build index as of writing

public class SceneButton : MonoBehaviour
{
    public void LoadScene(int a){
        SceneManager.LoadScene(a);
    }

    // gissa vad den här gör wowaoeoarewaoaweoo
    public void Quit(){
        Application.Quit();
    }
}
