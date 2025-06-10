using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FifthContentCloseWindows : MonoBehaviour
{
    public GameObject NeedClosedWindows1;
    public GameObject NeedClosedWindows2;
    public GameObject NeedClosedWindows3;
    public GameObject NeedClosedWindows4;
    public GameObject NeedClosedWindows5;

    public CanvasGroup FirstQuestionBoxCanvasGroup;
    public CanvasGroup ThirdQuestionBoxCanvasGroup;

    public void OnCloseButtonClick()
    {

        NeedClosedWindows1.SetActive(false);
        NeedClosedWindows2.SetActive(false);
        NeedClosedWindows3.SetActive(false);
        NeedClosedWindows4.SetActive(false);
        NeedClosedWindows5.SetActive(false);

        FirstQuestionBoxCanvasGroup.interactable = true;
        ThirdQuestionBoxCanvasGroup.interactable = true;
    }
}
