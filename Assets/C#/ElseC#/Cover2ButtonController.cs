using UnityEngine;

public class Cover2ButtonController : MonoBehaviour
{
    public GameObject TestContent;
    public GameObject TestAim;
    public GameObject TestScore;

    public void OnTextContentButtonClick()
    {
        TestContent.SetActive(true);
    }

    public void OnTextAimButtonClick()
    {
        TestAim.SetActive(true);
    }

    public void OnTextScoreButtonClick()
    {
        TestScore.SetActive(true);
    }

    public void OnCloseTextContentButtonClick()
    {
        TestContent.SetActive(false);
    }

    public void OnCloseTextAimButtonClick()
    {
        TestAim.SetActive(false);
    }

    public void OnCloseTextScoreButtonClick()
    {
        TestScore.SetActive(false);
    }
}
