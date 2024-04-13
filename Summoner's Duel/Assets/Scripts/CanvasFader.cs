using UnityEngine;
using DG.Tweening;

public class CanvasFader : MonoBehaviour
{
  public CanvasGroup canvasGroup;

  public float FadeDuration = 2.0f;

  public float Alpha
  {
    set
    {
      canvasGroup.alpha = value;
    }
  }

  public void FadeIn(System.Action onComplete = null)
  {
    canvasGroup.alpha = 0;
    canvasGroup.DOFade(1, FadeDuration).SetEase(Ease.Linear).OnComplete(() =>
    {
      if (onComplete != null)
      {
        onComplete();
      }
    });
  }

  public void FadeOut(System.Action onComplete = null)
  {
    canvasGroup.alpha = 1;
    canvasGroup.DOFade(0, FadeDuration).SetEase(Ease.Linear).OnComplete(() =>
    {
      if (onComplete != null)
      {
        onComplete();
      }
    });
  }
}