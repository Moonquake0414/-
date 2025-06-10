using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdContentCloseWindows : MonoBehaviour
{
    public GameObject NeedClosedWindows1;
    public GameObject NeedClosedWindows2;

    public CanvasGroup FourthQuestionBoxCanvasGroup;

    public void OnCloseButtonClick()
    {

        NeedClosedWindows1.SetActive(false);
        NeedClosedWindows2.SetActive(false);

        FourthQuestionBoxCanvasGroup.interactable = true;
    }
}
