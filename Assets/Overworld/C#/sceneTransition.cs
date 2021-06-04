using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneTransition : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;
   
    // Update is called once per frame
    void Update()
    {
       
        
    }
   

    public void LoadNextLevel(string scene)
    {
        //StartCoroutine(LoadLevel(SceneManager.LoadScene("Minigame 2")));
        transition.SetTrigger("Start");

        print(scene);

        new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(scene);
    }


}
