using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyKill : MonoBehaviour
{
    public void ReloadCurrentScene()
    {
        // get the current scene name 
        string sceneName = SceneManager.GetActiveScene().name;

        // load the same scene
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
}
