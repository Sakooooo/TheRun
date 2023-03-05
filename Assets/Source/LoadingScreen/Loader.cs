using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{

    public new string name = "MainMenu";

    void Start()
    {
//        LevelLoader(0);  

//   I need to use this more :eyes:
     if (Debug.isDebugBuild)
     {
     Debug.Log("Loader.cs INFO: Loading " + name);
     }

    StartCoroutine(LevelLoader(name));
    }
    
// TODO:: Make function that can get grabbed by other scenes to show level name

    public void LevelLoader (string name)
    {
      LoadASynchronously(name);
    }

    IEnumerator LoadASynchronously (string name)
    {
      AsyncOperation LoadStatus = SceneManager.LoadSceneAsync(name);

      while (!LoadStatus.isDone)
      {
        float progress = Mathf.Clamp01(LoadStatus.progress / .9f);
        Debug.Log(progress);

        yield return null;
      }
    }


// makes code unreadable and painful D:
/*
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
*/
}
