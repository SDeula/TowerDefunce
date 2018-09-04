using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LoadLevel : MonoBehaviour {

    public GameObject loadingScreen;
    public Slider slider;
    public Text ProgresText;

    public void loadLevel (int sceneIndex)
    {
        StartCoroutine(LoadAsunchronously(sceneIndex));  
    }

    IEnumerator LoadAsunchronously (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);

            slider.value = progress;
            ProgresText.text = progress * 100f + "%";

            yield return null;
        }
    }

}