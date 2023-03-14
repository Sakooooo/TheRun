using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader: MonoBehaviour
{
  // apparently not adding new hides this???
  public new string name = "MainMenu";
  
// https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.LoadSceneAsync.html
// i love reading documentation and im being serious sometimes its actually fun
  void Update()
  {
    if (UnityEngine.Debug.isDebugBuild)
    {
      Debug.Log("Source/Core/Loader.cs: Starting Asynchronous Scene Load For " + name);
    }


    StartCoroutine(LoadSceneAsync());
  }

  IEnumerator LoadSceneAsync()
  {
    AsyncOperation ASyncLoad = SceneManager.LoadSceneAsync(name);

    while (!ASyncLoad.isDone)
    {
      yield return null;
    }
  }


}
