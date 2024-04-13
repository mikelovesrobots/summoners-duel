using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroSceneSequencer : MonoBehaviour
{
  public SceneChanger SceneChanger;
  public CanvasFader TextFader;
  private bool transitioningOut = false;

  void Start()
  {
    TextFader.Alpha = 0.0f;
    Invoke("FadeInText", 0.5f);
  }

  public void OnClick()
  {
    FadeOutText();
    Invoke("ChangeScene", 0.5f);
  }

  void FadeInText()
  {
    TextFader.FadeIn();
  }

  void FadeOutText()
  {
    if (transitioningOut)
    {
      return;
    }
    TextFader.FadeOut();
    transitioningOut = true;
  }

  void ChangeScene()
  {
    SceneChanger.ChangeScene("GameScene");
  }
}
