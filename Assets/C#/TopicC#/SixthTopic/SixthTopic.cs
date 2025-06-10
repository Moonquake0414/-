using System;
using UnityEngine;
using UnityEngine.UI;

public class SixthTopic : MonoBehaviour
{
    public GameObject SixthContent;
    public GameObject FirstQuestionBox;
    public GameObject SecondQuestionBox;
    public GameObject SecondAnswerRight;
    public GameObject SecondAnswerWrong;
    public GameObject TipsWindows;

    public FirstTopic FirstTopic;
    public SecondTopic SecondTopic;
    public ThirdTopic ThirdTopic;
    public FourthTopic FourthTopic;
    public FifthTopic FifthTopic;
    public SeventhTopic SeventhTopic;
    public EighthTopic EighthTopic;
    public NinthTopic NinthTopic;
    public TenthTopic TenthTopic;
    public EleventhTopic EleventhTopic;
    public Text FirstText;
    public Text SecondText;
    public Text ThirdText;
    public Text FourthText;
    public Text FifthText;
    public Text SixthText;
    public CanvasGroup SecondQuestionBoxCanvasGroup;
    public Button TopicButton;
    public Button SixthToSeventhTopicButton;
    public Image image;

    //章节按钮是否被点击
    public bool isCall;

    //这一大题的每一小题是否提交
    public bool isSubmitFirstProblem;
    public bool isSubmitSecondProblem;
    public bool isSubmitThirdProblem;

    //这一大题的每一小题是否正确
    public bool FirstContent;
    public bool SecondContent;
    public bool ThirdContent;

    private void Start()
    {
        isCall = false;
        isSubmitFirstProblem = false;
        isSubmitSecondProblem = false;
        isSubmitThirdProblem = false;
        FirstContent = false;
        SecondContent = false;
        ThirdContent = false;
    }

    private void Update()
    {
        if (GlobalVariables.isFinishSixth == 3)
        {
            GlobalVariables.SixthTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
            GlobalVariables.isFinishSixth++;
            GlobalVariables.SixthTime = (int)(GlobalVariables.SixthTimeOver - GlobalVariables.SixthTimeBegin);
        }

        if (!isCall)
        {
            GlobalVariables.SixthTimeBegin = ChangeTime.Changetime(DateTime.Now.ToString());
            GlobalVariables.SixthTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
        }

        if (isCall && !isSubmitFirstProblem)
        {
            GlobalVariables.SixthTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
        }
    }

    #region 章节跳转
    public void OnSixthTopicButtonClick()
    {
        FirstTopic.FirstContent.SetActive(false);
        SecondTopic.SecondContent.SetActive(false);
        ThirdTopic.ThirdContent.SetActive(false);
        FourthTopic.FourthContent.SetActive(false);
        FifthTopic.FifthContent.SetActive(false);
        SeventhTopic.SeventhContent.SetActive(false);
        EighthTopic.EighthContent.SetActive(false);
        NinthTopic.NinthContent.SetActive(false);
        TenthTopic.TenthContent.SetActive(false);
        EleventhTopic.EleventhContent.SetActive(false);
        SixthContent.SetActive(true);

        image.color = new Color(0, 0, 0);
        SecondTopic.image.color = new Color(255, 255, 255);
        ThirdTopic.image.color = new Color(255, 255, 255);
        FourthTopic.image.color = new Color(255, 255, 255);
        FifthTopic.image.color = new Color(255, 255, 255);
        FirstTopic.image.color = new Color(255, 255, 255);
        SeventhTopic.image.color = new Color(255, 255, 255);
        EighthTopic.image.color = new Color(255, 255, 255);
        NinthTopic.image.color = new Color(255, 255, 255);
        TenthTopic.image.color = new Color(255, 255, 255);
        EleventhTopic.image.color = new Color(255, 255, 255);

        if (!isCall)
        {
            GlobalVariables.SixthTimeBegin = ChangeTime.Changetime(DateTime.Now.ToString());
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

    public void SecondQuestionReturnFirstQuestion()
    {
        FirstQuestionBox.SetActive(true);
        SecondQuestionBox.SetActive(false);
    }
    #endregion

    #region 本章节第二题提交
    public void OnSecondSubmitButtonClick()
    {
        SecondQuestionBoxCanvasGroup.interactable = false;
        if (FirstText.text == "" || SecondText.text == "" || ThirdText.text == "" || FourthText.text == "" || FifthText.text == "" || SixthText.text == "")
        {
            TipsWindows.SetActive(true);
        }
        else
        {
            if ((FirstText.text == "霍夫曼编码" && SecondText.text == "算术编码") 
               ||(FirstText.text == "算术编码" && SecondText.text == "霍夫曼编码"))
            {
                FirstContent = true;
                if(!isSubmitFirstProblem)
                {
                    GlobalVariables.score += 4;
                    GlobalVariables.SixthScore += 4;
                    GlobalVariables.isFinishSixth++;
                    isSubmitFirstProblem = true;
                }
            }
            else
            {
                FirstContent = false;
                if (!isSubmitFirstProblem)
                {
                    GlobalVariables.isFinishSixth++;
                    isSubmitFirstProblem = true;
                }
            }

            if ((ThirdText.text.Contains("DPCM") && FourthText.text.Contains("DCT")) ||
                (ThirdText.text.Contains("DCT") && FourthText.text.Contains("DPCM")))
            {
                SecondContent = true;
                if (!isSubmitSecondProblem)
                {
                    GlobalVariables.score += 4;
                    GlobalVariables.SixthScore += 4;
                    GlobalVariables.isFinishSixth++;
                    isSubmitSecondProblem = true;
                }
            }
            else
            {
                SecondContent = false;
                if (!isSubmitSecondProblem)
                {
                    GlobalVariables.isFinishSixth++;
                    isSubmitSecondProblem = true;
                }
            }

            if ((FifthText.text.Contains("压缩比") || FifthText.text.Contains("平均码字长度") || FifthText.text.Contains("编码效率") || FifthText.text.Contains("冗余度"))
                && (SixthText.text.Contains("压缩比") || SixthText.text.Contains("平均码字长度") || SixthText.text.Contains("编码效率") || SixthText.text.Contains("冗余度")))
            {
                ThirdContent = true;
                if (!isSubmitThirdProblem)
                {
                    GlobalVariables.score += 2;
                    GlobalVariables.SixthScore += 2;
                    GlobalVariables.isFinishSixth++;
                    isSubmitThirdProblem = true;
                }
            }
            else
            {
                ThirdContent = false;
                if (!isSubmitThirdProblem)
                {
                    GlobalVariables.isFinishSixth++;
                    isSubmitThirdProblem = true;
                }
            }

            if (FirstContent && SecondContent && ThirdContent)
            {
                SecondAnswerRight.SetActive(true);
            }
            else
            {
                SecondAnswerWrong.SetActive(true);
            }
        }
    }
    #endregion
}
