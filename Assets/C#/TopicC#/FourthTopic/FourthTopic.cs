using System;
using UnityEngine;
using UnityEngine.UI;

public class FourthTopic : MonoBehaviour
{
    public GameObject FourthContent;
    public GameObject FirstQuestionBox;
    public GameObject SecondQuestionBox;
    public GameObject ThirdQuestionBox;
    public GameObject ThirdAnswerRight;
    public GameObject ThirdAnswerWrong;
    public GameObject TipsWindows;

    public FirstTopic FirstTopic;
    public SecondTopic SecondTopic;
    public ThirdTopic ThirdTopic;
    public FifthTopic FifthTopic;
    public SixthTopic SixthTopic;
    public SeventhTopic SeventhTopic;
    public EighthTopic EighthTopic;
    public NinthTopic NinthTopic;
    public TenthTopic TenthTopic;
    public EleventhTopic EleventhTopic;
    public Text FirstText;
    public Text SecondText;
    public Text ThirdText;
    public Text FourthText;
    public CanvasGroup ThirdQuestionBoxCanvasGroup;
    public Button TopicButton;
    public Button FourthToFifthTopicButton;
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
        if (GlobalVariables.isFinishFourth == 1)
        {
            GlobalVariables.FourthTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
            GlobalVariables.isFinishFourth++;
            GlobalVariables.FourthTime = (int)(GlobalVariables.FourthTimeOver - GlobalVariables.FourthTimeBegin);
        }

        if (!isCall)
        {
            GlobalVariables.FourthTimeBegin = ChangeTime.Changetime(DateTime.Now.ToString());
            GlobalVariables.FourthTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
        }

        if (isCall && !isSubmitFirst)
        {
            GlobalVariables.FourthTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
        }
    }

    #region 章节跳转
    public void OnFourthTopicButtonClick()
    {
        FirstTopic.FirstContent.SetActive(false);
        SecondTopic.SecondContent.SetActive(false);
        ThirdTopic.ThirdContent.SetActive(false);
        FifthTopic.FifthContent.SetActive(false);
        SixthTopic.SixthContent.SetActive(false);
        SeventhTopic.SeventhContent.SetActive(false);
        EighthTopic.EighthContent.SetActive(false);
        NinthTopic.NinthContent.SetActive(false);
        TenthTopic.TenthContent.SetActive(false);
        EleventhTopic.EleventhContent.SetActive(false);
        FourthContent.SetActive(true);

        image.color = new Color(0, 0, 0);
        SecondTopic.image.color = new Color(255, 255, 255);
        ThirdTopic.image.color = new Color(255, 255, 255);
        FirstTopic.image.color = new Color(255, 255, 255);
        FifthTopic.image.color = new Color(255, 255, 255);
        SixthTopic.image.color = new Color(255, 255, 255);
        SeventhTopic.image.color = new Color(255, 255, 255);
        EighthTopic.image.color = new Color(255, 255, 255);
        NinthTopic.image.color = new Color(255, 255, 255);
        TenthTopic.image.color = new Color(255, 255, 255);
        EleventhTopic.image.color = new Color(255, 255, 255);

        if (!isCall)
        {
            GlobalVariables.FourthTimeBegin = ChangeTime.Changetime(DateTime.Now.ToString());
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

    #region 题目提交
    public void OnThirdSubmitButtonClick()
    {
        ThirdQuestionBoxCanvasGroup.interactable = false;
        if(FirstText.text == "" || SecondText.text == "" || ThirdText.text == "" || FourthText.text == "")
        {
            TipsWindows.SetActive(true);
        }
        else
        {
            bool FirstContent = false;
            bool SecondContent = false;
            if (FirstText.text.Contains("客观保真度") && SecondText.text.Contains("主观保真度") || (FirstText.text.Contains("主观保真度") && SecondText.text.Contains("客观保真度")))
            {
                FirstContent = true;
            }
            else
            {
                FirstContent = false;
            }

            if ((ThirdText.text == "均方根误差" && FourthText.text == "均方根信噪比") || (ThirdText.text == "均方根信噪比" && FourthText.text == "均方根误差"))
            {
                SecondContent = true;
            }
            else
            {
                SecondContent = false;
            }

            if (FirstContent && SecondContent)
            {
                ThirdAnswerRight.SetActive(true);
                if(!isSubmitFirst)
                {
                    GlobalVariables.score += 16;
                    GlobalVariables.FourthScore += 16;
                    GlobalVariables.isFinishFourth++;
                    isSubmitFirst = true;
                }
            }
            else
            {
                ThirdAnswerWrong.SetActive(true);
                if (!isSubmitFirst)
                {
                    GlobalVariables.isFinishFourth++;
                    isSubmitFirst = true;
                }
            }
        }
    }
    #endregion
}
