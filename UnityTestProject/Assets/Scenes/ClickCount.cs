using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickCount : MonoBehaviour, IPointerClickHandler
{
    private int clickCount;

    public void OnPointerClick(PointerEventData eventData)
    {
        clickCount++;
        GetComponent<Text>().text = $"Click count {clickCount}";
    }
}