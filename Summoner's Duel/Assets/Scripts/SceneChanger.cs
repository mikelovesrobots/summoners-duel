using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public CanvasFader CanvasFader;

    void Start()
    {
        CanvasFader.FadeIn();
    }

    public void ChangeScene(string sceneName)
    {
        CanvasFader.FadeOut(() =>
        {
            SceneManager.LoadScene(sceneName);
        });
    }
}
