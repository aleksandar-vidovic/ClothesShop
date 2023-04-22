using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScene : MonoBehaviour
{
    private IEnumerator LoadASync(int scene)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(scene);

        while (!asyncOperation.isDone)
            yield return null;
    }

    public void SceneLoading(int scene)
    {
        StartCoroutine(LoadASync(scene));
    }
}