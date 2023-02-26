using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{

    void Start()
    {
        LevelLoader(0);  
    }


    int SceneIndex = 2;

    public void LevelLoader (int SceneIndex)
    {
        StartCoroutine(LoadASynchronously(SceneIndex));
    }

    IEnumerator LoadASynchronously (int SceneIndex)
    {
        AsyncOperation LoadStatus = SceneManager.LoadSceneAsync(SceneIndex);

        while (!LoadStatus.isDone)
        {
            float progress = Mathf.Clamp01(LoadStatus.progress / .9f);
            Debug.Log(progress);

            yield return null;
        }
    }

}
