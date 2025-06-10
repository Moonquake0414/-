using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeventhContentCloseWindows : MonoBehaviour
{
    public GameObject NeedClosedWindows1;
    public GameObject NeedClosedWindows2;
    public GameObject NeedClosedWindows3;

    public CanvasGroup ThirdQuestionBoxCanvasGroup;
    public CanvasGroup FourthQuestionBoxCanvasGroup;

    public void OnCloseButtonClick()
    {
        NeedClosedWindows1.SetActive(false);
        NeedClosedWindows2.SetActive(false);
        NeedClosedWindows3.SetActive(false);

        ThirdQuestionBoxCanvasGroup.interactable = true;
        FourthQuestionBoxCanvasGroup.interactable = true;
    }
}
