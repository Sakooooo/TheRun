using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{

  public string name = "MainMenu";
  
// https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.LoadSceneAsync.html
  void Update()
  {
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
