using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ShowMessage : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string message;
    public TMP_Text textObject;
    public GameObject messageGameObject;

    public void OnPointerEnter(PointerEventData eventData)
    {
        textObject.text = message;
        messageGameObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        messageGameObject.SetActive(false);
    }
}
