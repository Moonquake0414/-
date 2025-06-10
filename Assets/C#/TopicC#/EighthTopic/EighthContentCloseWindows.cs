using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EighthContentCloseWindows : MonoBehaviour
{
    public GameObject NeedClosedWindows1;
    public GameObject NeedClosedWindows2;

    public CanvasGroup ThirdQuestionBoxCanvasGroup;

    public void OnCloseButtonClick()
    {
        NeedClosedWindows1.SetActive(false);
        NeedClosedWindows2.SetActive(false);

        ThirdQuestionBoxCanvasGroup.interactable = true;
    }
}
