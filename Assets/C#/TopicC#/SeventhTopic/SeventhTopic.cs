using System;
using UnityEngine;
using UnityEngine.UI;

public class SeventhTopic : MonoBehaviour
{
    public GameObject SeventhContent;
    public GameObject SecondQuestionBox;
    public GameObject ThirdQuestionBox;
    public GameObject FourthQuestionBox;
    public GameObject ThirdAnswerRight;
    public GameObject ThirdAnswerWrong;
    public GameObject FourthAnswerRight;
    public GameObject TipsWindows;

    public FirstTopic FirstTopic;
    public SecondTopic SecondTopic;
    public ThirdTopic ThirdTopic;
    public FourthTopic FourthTopic;
    public FifthTopic FifthTopic;
    public SixthTopic SixthTopic;
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
    public Text SeventhText;
    public Text EighthText;
    public Text NinthText;
    public Text TenthText;
    public Text EleventhText;
    public Text TwelveText;
    public Text ThirteenText;
    public CanvasGroup ThirdQuestionBoxCanvasGroup;
    public CanvasGroup FourthQuestionBoxCanvasGroup;
    public Button TopicButton;
    public Button SeventhToEighthTopicButton;
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
        if (GlobalVariables.isFinishSeventh == 1)
        {
            GlobalVariables.SeventhTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
            GlobalVariables.isFinishSeventh++;
            GlobalVariables.SeventhTime = (int)(GlobalVariables.SeventhTimeOver - GlobalVariables.SeventhTimeBegin);
        }

        if (!isCall)
        {
            GlobalVariables.SeventhTimeBegin = ChangeTime.Changetime(DateTime.Now.ToString());
            GlobalVariables.SeventhTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
        }

        if (isCall && !isSubmitFirst)
        {
            GlobalVariables.SeventhTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
        }
    }

    #region 章节跳转
    public void OnSeventhTopicButtonClick()
    {
        FirstTopic.FirstContent.SetActive(false);
        SecondTopic.SecondContent.SetActive(false);
        ThirdTopic.ThirdContent.SetActive(false);
        FourthTopic.FourthContent.SetActive(false);
        FifthTopic.FifthContent.SetActive(false);
        SixthTopic.SixthContent.SetActive(false);
        EighthTopic.EighthContent.SetActive(false);
        NinthTopic.NinthContent.SetActive(false);
        TenthTopic.TenthContent.SetActive(false);
        EleventhTopic.EleventhContent.SetActive(false);
        SeventhContent.SetActive(true);

        image.color = new Color(0, 0, 0);
        SecondTopic.image.color = new Color(255, 255, 255);
        ThirdTopic.image.color = new Color(255, 255, 255);
        FourthTopic.image.color = new Color(255, 255, 255);
        FifthTopic.image.color = new Color(255, 255, 255);
        SixthTopic.image.color = new Color(255, 255, 255);
        FirstTopic.image.color = new Color(255, 255, 255);
        EighthTopic.image.color = new Color(255, 255, 255);
        NinthTopic.image.color = new Color(255, 255, 255);
        TenthTopic.image.color = new Color(255, 255, 255);
        EleventhTopic.image.color = new Color(255, 255, 255);

        if (!isCall)
        {
            GlobalVariables.SeventhTimeBegin = ChangeTime.Changetime(DateTime.Now.ToString());
            isCall = true;
        }
    }
    #endregion

    #region 题目跳转
    public void SecondQuestionToThirdQuestion()
    {
        SecondQuestionBox.SetActive(false);
        ThirdQuestionBox.SetActive(true);
    }

    public void ThirdQuestionToFourthQuestion()
    {
        ThirdQuestionBox.SetActive(false);
        FourthQuestionBox.SetActive(true);
    }

    public void ThirdQuestionReturnSecondQuestion()
    {
        SecondQuestionBox.SetActive(true);
        ThirdQuestionBox.SetActive(false);
    }

    public void FourthQuestionReturnThirdQuestion()
    {
        ThirdQuestionBox.SetActive(true);
        FourthQuestionBox.SetActive(false);
    }
    #endregion

    #region 题目提交
    public void OnThirdSubmitButtonClick()
    {
        ThirdQuestionBoxCanvasGroup.interactable = false;
        
        if(FirstText.text == "" || SecondText.text == "" || ThirdText.text == "" || FourthText.text == "" || FifthText.text == ""
            || SixthText.text == "" || SeventhText.text == "" || EighthText.text == "" || NinthText.text == "" || TenthText.text == "")
        {
            TipsWindows.SetActive(true);
        }
        else
        {
            if (FirstText.text == "00" && SecondText.text == "000" && ThirdText.text == "01" && FourthText.text == "010" && FifthText.text == "001"
                        && SixthText.text == "0110" && SeventhText.text == "011" && EighthText.text == "01110" && NinthText.text == "0111" && TenthText.text == "01111")
            {
                ThirdAnswerRight.SetActive(true);
                if(!isSubmitFirst)
                {
                    GlobalVariables.score += 10;
                    GlobalVariables.SeventhScore += 10;
                    GlobalVariables.isFinishSeventh++;
                    isSubmitFirst = true;
                }
            }
            else
            {
                ThirdAnswerWrong.SetActive(true);
                if (!isSubmitFirst)
                {
                    GlobalVariables.isFinishSeventh++;
                    isSubmitFirst = true;
                }
            }
        }
    }

    public void OnFourthSubmitButtonClick()
    {
        FourthQuestionBoxCanvasGroup.interactable = false;
        if (EleventhText.text == "" || TwelveText.text == "" || ThirteenText.text == "")
        {
            TipsWindows.SetActive(true);
        }
        else
        {
            FourthAnswerRight.SetActive(true);
        }
    }
    #endregion
}
