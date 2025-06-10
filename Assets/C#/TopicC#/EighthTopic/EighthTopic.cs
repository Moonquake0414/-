using System;
using UnityEngine;
using UnityEngine.UI;

public class EighthTopic : MonoBehaviour
{
    public GameObject EighthContent;
    public GameObject FirstQuestionBox;
    public GameObject SecondQuestionBox;
    public GameObject ThirdQuestionBox;
    public GameObject ThirdAnswerRight;
    public GameObject ThirdAnswerWrong;
    public GameObject TipsWindows;

    public FirstTopic FirstTopic;
    public SecondTopic SecondTopic;
    public ThirdTopic ThirdTopic;
    public FourthTopic FourthTopic;
    public FifthTopic FifthTopic;
    public SixthTopic SixthTopic;
    public SeventhTopic SeventhTopic;
    public NinthTopic NinthTopic;
    public TenthTopic TenthTopic;
    public EleventhTopic EleventhTopic;
    public Text FirstText;
    public CanvasGroup ThirdQuestionBoxCanvasGroup;
    public Button TopicButton;
    public Button EighthToNinthTopicButton;
    public Image image;

    //章节按钮是否被点击
    public bool isCall;

    //每一题是否提交
    public bool isSubmitFirst;

    private void Start()
    {
        isCall = false;
        isSubmitFirst = false;
    }

    private void Update()
    {
        if (GlobalVariables.isFinishEighth == 1)
        {
            GlobalVariables.EighthTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
            GlobalVariables.isFinishEighth++;
            GlobalVariables.EighthTime = (int)(GlobalVariables.EighthTimeOver - GlobalVariables.EighthTimeBegin);
        }

        if (!isCall)
        {
            GlobalVariables.EighthTimeBegin = ChangeTime.Changetime(DateTime.Now.ToString());
            GlobalVariables.EighthTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
        }

        if (isCall && !isSubmitFirst)
        {
            GlobalVariables.EighthTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
        }
    }

    #region 章节跳转
    public void OnEighthTopicButtonClick()
    {
        FirstTopic.FirstContent.SetActive(false);
        SecondTopic.SecondContent.SetActive(false);
        ThirdTopic.ThirdContent.SetActive(false);
        FourthTopic.FourthContent.SetActive(false);
        FifthTopic.FifthContent.SetActive(false);
        SixthTopic.SixthContent.SetActive(false);
        SeventhTopic.SeventhContent.SetActive(false);
        NinthTopic.NinthContent.SetActive(false);
        TenthTopic.TenthContent.SetActive(false);
        EleventhTopic.EleventhContent.SetActive(false);
        EighthContent.SetActive(true);

        image.color = new Color(0, 0, 0);
        SecondTopic.image.color = new Color(255, 255, 255);
        ThirdTopic.image.color = new Color(255, 255, 255);
        FourthTopic.image.color = new Color(255, 255, 255);
        FifthTopic.image.color = new Color(255, 255, 255);
        SixthTopic.image.color = new Color(255, 255, 255);
        SeventhTopic.image.color = new Color(255, 255, 255);
        FirstTopic.image.color = new Color(255, 255, 255);
        NinthTopic.image.color = new Color(255, 255, 255);
        TenthTopic.image.color = new Color(255, 255, 255);
        EleventhTopic.image.color = new Color(255, 255, 255);

        if (!isCall)
        {
            GlobalVariables.EighthTimeBegin = ChangeTime.Changetime(DateTime.Now.ToString());
            isCall = true;
        }
    }
    #endregion

    #region 题目跳转
    public void FirstQuestionToSecondQuestion()
    {
        FirstQuestionBox.SetActive(false);
        SecondQuestionBox.SetActive(true);
    }

    public void SecondQuestionToThirdQuestion()
    {
        SecondQuestionBox.SetActive(false);
        ThirdQuestionBox.SetActive(true);
    }

    public void SecondQuestionReturnFirstQuestion()
    {
        FirstQuestionBox.SetActive(true);
        SecondQuestionBox.SetActive(false);
    }

    public void ThirdQuestionReturnSecondQuestion()
    {
        SecondQuestionBox.SetActive(true);
        ThirdQuestionBox.SetActive(false);
    }
    #endregion

    #region 题目提交
    public void OnThirdSubmitButtonClick()
    {
        ThirdQuestionBoxCanvasGroup.interactable = false;
        if (FirstText.text == "")
        {
            TipsWindows.SetActive(true);
        }
        else
        {
            if (FirstText.text == "正确")
            {
                ThirdAnswerRight.SetActive(true);
                if(!isSubmitFirst)
                {
                    GlobalVariables.score += 4;
                    GlobalVariables.EighthScore += 4;
                    GlobalVariables.isFinishEighth++;
                    isSubmitFirst = true;
                }
            }
            else
            {
                ThirdAnswerWrong.SetActive(true);
                if (!isSubmitFirst)
                {
                    GlobalVariables.isFinishEighth++;
                    isSubmitFirst = true;
                }
            }
        }
    }
    #endregion
}
