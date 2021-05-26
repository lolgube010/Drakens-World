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
        if (Input.GetKey(KeyCode.Space))
        {
            LoadNextLevel();
        }
        
    }

    public void LoadNextLevel()
    {
        //denna kod startar en courontine /johan.
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        //detta startar en animation /johan.
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        //detta byter scene /johan.
        SceneManager.LoadScene(levelIndex);
    }
}
