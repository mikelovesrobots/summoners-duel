using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenuController : MonoBehaviour
{
  public SceneChanger SceneChanger;

  public void PlayGame()
  {
    SceneChanger.ChangeScene("IntroScene");
  }

  public void QuitGame()
  {
    Application.Quit();
  }
}
