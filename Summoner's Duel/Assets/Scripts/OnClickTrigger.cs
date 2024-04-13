using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class OnClickTrigger : MonoBehaviour, IPointerClickHandler
{
    public UnityEvent onClickEvent;

    public void OnPointerClick(PointerEventData eventData)
    {
        onClickEvent.Invoke();
    }
}