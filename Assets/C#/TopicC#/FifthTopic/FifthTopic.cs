using System;
using UnityEngine;
using UnityEngine.UI;

public class FifthTopic : MonoBehaviour
{
    public GameObject FifthContent;
    public GameObject Image1;
    public GameObject Image2;
    public GameObject Image3;
    public GameObject Image4;
    public GameObject FirstQuestionBox;
    public GameObject SecondQuestionBox;
    public GameObject ThirdQuestionBox;
    public GameObject ThirdAnswerRight;
    public GameObject TipsWindows;

    public FirstTopic FirstTopic;
    public SecondTopic SecondTopic;
    public ThirdTopic ThirdTopic;
    public FourthTopic FourthTopic;
    public SixthTopic SixthTopic;
    public SeventhTopic SeventhTopic;
    public EighthTopic EighthTopic;
    public NinthTopic NinthTopic;
    public TenthTopic TenthTopic;
    public EleventhTopic EleventhTopic;

    public CanvasGroup FirstQuestionBoxCanvasGroup;
    public CanvasGroup ThirdQuestionBoxCanvasGroup;
    public Button TopicButton;
    public Button FifthToSixthTopicButton;
    public Text FirstText;
    public Image image;
    public InputField ProjectReport;

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
        if (GlobalVariables.isFinishFifth == 1)
        {
            GlobalVariables.FifthTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
            GlobalVariables.isFinishFifth++;
            GlobalVariables.FifthTime = (int)(GlobalVariables.FifthTimeOver - GlobalVariables.FifthTimeBegin);
        }

        if (!isCall)
        {
            GlobalVariables.FifthTimeBegin = ChangeTime.Changetime(DateTime.Now.ToString());
            GlobalVariables.FifthTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
        }

        if (isCall && !isSubmitFirst)
        {
            GlobalVariables.FifthTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
        }
    }

    #region 章节跳转
    public void OnFifthTopicButtonClick()
    {
        FirstTopic.FirstContent.SetActive(false);
        SecondTopic.SecondContent.SetActive(false);
        ThirdTopic.ThirdContent.SetActive(false);
        FourthTopic.FourthContent.SetActive(false);
        SixthTopic.SixthContent.SetActive(false);
        SeventhTopic.SeventhContent.SetActive(false);
        EighthTopic.EighthContent.SetActive(false);
        NinthTopic.NinthContent.SetActive(false);
        TenthTopic.TenthContent.SetActive(false);
        EleventhTopic.EleventhContent.SetActive(false);
        FifthContent.SetActive(true);

        image.color = new Color(0, 0, 0);
        SecondTopic.image.color = new Color(255, 255, 255);
        ThirdTopic.image.color = new Color(255, 255, 255);
        FourthTopic.image.color = new Color(255, 255, 255);
        FirstTopic.image.color = new Color(255, 255, 255);
        SixthTopic.image.color = new Color(255, 255, 255);
        SeventhTopic.image.color = new Color(255, 255, 255);
        EighthTopic.image.color = new Color(255, 255, 255);
        NinthTopic.image.color = new Color(255, 255, 255);
        TenthTopic.image.color = new Color(255, 255, 255);
        EleventhTopic.image.color = new Color(255, 255, 255);

        if (!isCall)
        {
            GlobalVariables.FifthTimeBegin = ChangeTime.Changetime(DateTime.Now.ToString());
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

    public void ThirdQuestionReturnSeondQuestion()
    {
        SecondQuestionBox.SetActive(true);
        ThirdQuestionBox.SetActive(false);
    }
    #endregion

    #region 题目点击
    public void OnFirstQuestionBoxFirstButtonClick()
    {
        FirstQuestionBoxCanvasGroup.interactable = false;
        Image1.SetActive(true);
    }

    public void OnFirstQuestionBoxSecondButtonClick()
    {
        Image2.SetActive(true);
        FirstQuestionBoxCanvasGroup.interactable = false;
    }

    public void OnFirstQuestionBoxThirdButtonClick()
    {
        Image3.SetActive(true);
        FirstQuestionBoxCanvasGroup.interactable = false;
    }

    public void OnFirstQuestionBoxFourthButtonClick()
    {
        Image4.SetActive(true);
        FirstQuestionBoxCanvasGroup.interactable = false;
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
            ThirdAnswerRight.SetActive(true);
            GlobalVariables.projectReport = "请简述一个生活中图像处理的应用实例:" + ProjectReport.text;
            if(!isSubmitFirst)
            {
                GlobalVariables.score += 4;
                GlobalVariables.FifthScore += 4;
                GlobalVariables.isFinishFifth++;
                isSubmitFirst = true;
            }
        }
    }
    #endregion
}
