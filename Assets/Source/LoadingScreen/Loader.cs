using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{

  public string name = "MainMenu";
  
// https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.LoadSceneAsync.html
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
