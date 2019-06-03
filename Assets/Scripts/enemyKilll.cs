using UnityEngine.SceneManagement;

public class enemyKilll
{
    public void ReloadCurrentScene()
    {
        // get the current scene name 
        string sceneName = SceneManager.GetActiveScene().name;

        // load the same scene
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
}