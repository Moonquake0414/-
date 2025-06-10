using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SixthContentCloseWindows : MonoBehaviour
{
    public GameObject NeedClosedWindows1;
    public GameObject NeedClosedWindows2;

    public CanvasGroup SecondQuestionBoxCanvasGroup;

    public void OnCloseButtonClick()
    {
        NeedClosedWindows1.SetActive(false);
        NeedClosedWindows2.SetActive(false);

        SecondQuestionBoxCanvasGroup.interactable = true;
    }
}
