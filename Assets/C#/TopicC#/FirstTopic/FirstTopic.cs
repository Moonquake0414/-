using System;
using UnityEngine;
using UnityEngine.UI;

public class FirstTopic : MonoBehaviour
{
    public GameObject FirstContent;
    public GameObject ZeroQuestionBox;
    public GameObject FirstQuestionBox;
    public GameObject SecondQuestionBox;
    public GameObject ZeroAnswer;
    public GameObject FirstAnswerRight;
    public GameObject FirstAnswerWrong;
    public GameObject SecondAnswerRight;
    public GameObject SecondAnswerWrong;
    public GameObject TipsWindows;

    public SecondTopic SecondTopic;
    public ThirdTopic ThirdTopic;
    public FourthTopic FourthTopic;
    public FifthTopic FifthTopic;
    public SixthTopic SixthTopic;
    public SeventhTopic SeventhTopic;
    public EighthTopic EighthTopic;
    public NinthTopic NinthTopic;
    public TenthTopic TenthTopic;
    public EleventhTopic EleventhTopic;

    public Text FirstAnswerText;
    public InputField FirstInputField;
    public Toggle FirstToggle;
    public Toggle SecondToggle;
    public Toggle ThirdToggle;
    public Toggle FourthToggle;
    public Toggle FifthToggle;
    public Toggle SixthToggle;
    public Toggle SeventhToggle;
    public Toggle EighthToggle;
    public CanvasGroup ZeroQuestionBoxCanvasGroup;
    public CanvasGroup FirstQuestionBoxCanvasGroup;
    public CanvasGroup SecondQuestionBoxCanvasGroup;
    public Button TopicButton;
    public Button FirstToSecondTopicButton;
    public Image image;

    //每一题是否提交
    public bool isSubmitFirst;
    public bool isSubmitSecond;

    private void Start()
    {
        image.color = new Color(0, 0, 0);
        isSubmitFirst = false;
        isSubmitSecond = false;
    }

    private void Update()
    {
        //题目全部完成视为本章节完成，记录章节结束时间并计算章节用时
        if (GlobalVariables.isFinishFirst == 2)
        {
            GlobalVariables.FirstTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());//章节结束时间被重置
            GlobalVariables.isFinishFirst++;
            GlobalVariables.FirstTime = (int)(GlobalVariables.FirstTimeOver - GlobalVariables.satrtTime);//章节用时被重置
            Debug.Log(GlobalVariables.FirstTime);
        }
        else if(!isSubmitFirst ||  !isSubmitSecond)
        {
            GlobalVariables.FirstTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
        }
    }
    #region 章节跳转
    public void OnFirstTopicButtonClick()
    {
        SecondTopic.SecondContent.SetActive(false);
        ThirdTopic.ThirdContent.SetActive(false);
        FourthTopic.FourthContent.SetActive(false);
        FifthTopic.FifthContent.SetActive(false);
        SixthTopic.SixthContent.SetActive(false);
        SeventhTopic.SeventhContent.SetActive(false);
        EighthTopic.EighthContent.SetActive(false);
        NinthTopic.NinthContent.SetActive(false);
        TenthTopic.TenthContent.SetActive(false);
        EleventhTopic.EleventhContent.SetActive(false);
        FirstContent.SetActive(true);

        image.color = new Color(0, 0, 0);
        SecondTopic.image.color = new Color(255, 255, 255);
        ThirdTopic.image.color = new Color(255, 255, 255);
        FourthTopic.image.color = new Color(255, 255, 255);
        FifthTopic.image.color = new Color(255, 255, 255);
        SixthTopic.image.color = new Color(255, 255, 255);
        SeventhTopic.image.color = new Color(255, 255, 255);
        EighthTopic.image.color = new Color(255, 255, 255);
        NinthTopic.image.color = new Color(255, 255, 255);
        TenthTopic.image.color = new Color(255, 255, 255);
        EleventhTopic.image.color = new Color(255, 255, 255);
    }
    #endregion

    #region 题目提交
    public void OnZeroSubmitButtonClick()
    {
        ZeroQuestionBoxCanvasGroup.interactable = false;
        ZeroAnswer.SetActive(true);
    }

    public void OnFirstSubmitButtonClick()
    {
        FirstQuestionBoxCanvasGroup.interactable = false;
        if (!FifthToggle.isOn && !SixthToggle.isOn && !SeventhToggle.isOn && !EighthToggle.isOn)
        {
            TipsWindows.SetActive(true);
        }
        else
        {
            if (FifthToggle.isOn && SixthToggle.isOn && SeventhToggle.isOn && EighthToggle.isOn)
            {
                FirstAnswerRight.SetActive(true);
                if (!isSubmitFirst)
                {
                    GlobalVariables.score += 5;
                    GlobalVariables.FirstScore += 5;
                    GlobalVariables.isFinishFirst++;
                    isSubmitFirst = true;
                }
            }
            else
            {
                FirstAnswerWrong.SetActive(true);
                if (!isSubmitFirst)
                {
                    GlobalVariables.isFinishFirst++;
                    isSubmitFirst = true;
                }
            }
        }
    }

    public void OnSecondSubmitButtonClick()
    {
        SecondQuestionBoxCanvasGroup.interactable = false;
        if (!FirstToggle.isOn && !SecondToggle.isOn && !ThirdToggle.isOn && !FourthToggle.isOn)
        {
            TipsWindows.SetActive(true);
        }
        else
        {
            if (FirstToggle.isOn && SecondToggle.isOn && ThirdToggle.isOn && FourthToggle.isOn)
            {
                SecondAnswerRight.SetActive(true);
                if(!isSubmitSecond)
                {
                    GlobalVariables.score += 5;
                    GlobalVariables.FirstScore += 5;
                    GlobalVariables.isFinishFirst++;
                    isSubmitSecond = true;
                }
            }
            else
            {
                SecondAnswerWrong.SetActive(true);
                if (!isSubmitSecond)
                {
                    GlobalVariables.isFinishFirst++;
                    isSubmitSecond = true;
                }
            }
        }
        
    }
    #endregion

    #region 题目跳转
    public void ZeroQuestionToFirstQuestion()
    {
        ZeroQuestionBox.SetActive(false);
        FirstQuestionBox.SetActive(true);
    }

    public void FirstQuestionReturnZeroQuestion()
    {
        FirstQuestionBox.SetActive(false);
        ZeroQuestionBox.SetActive(true);
    }

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
}
