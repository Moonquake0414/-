using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstContentCloseWindows : MonoBehaviour
{
    public GameObject NeedClosedWindows0;
    public GameObject NeedClosedWindows1;
    public GameObject NeedClosedWindows2;
    public GameObject NeedClosedWindows3;
    public GameObject NeedClosedWindows4;

    public CanvasGroup ZeroQuestionBoxCanvasGroup;
    public CanvasGroup FirstQuestionBoxCanvasGroup;
    public CanvasGroup SecondQuestionBoxCanvasGroup;

    public void OnCloseButtonClick()
    {
        NeedClosedWindows0.SetActive(false);
        NeedClosedWindows1.SetActive(false);
        NeedClosedWindows2.SetActive(false);
        NeedClosedWindows3.SetActive(false);
        NeedClosedWindows4.SetActive(false);

        ZeroQuestionBoxCanvasGroup.interactable = true;
        FirstQuestionBoxCanvasGroup.interactable = true;
        SecondQuestionBoxCanvasGroup.interactable = true;
    }
}
