using UnityEngine;

public class CloseTipsWindowsButtom : MonoBehaviour
{
    public GameObject TipsWindows;

    public CanvasGroup FirstQuestionBoxCanvasGroup;
    public CanvasGroup SecondQuestionBoxCanvasGroup;
    public void OnCloseTipsWindowsButton()
    {
        TipsWindows.SetActive(false);

        FirstQuestionBoxCanvasGroup.interactable = true;
        SecondQuestionBoxCanvasGroup.interactable = true;
    }
}
