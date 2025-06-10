using System;
using UnityEngine;
using UnityEngine.UI;

public class SecondTopic : MonoBehaviour
{
    public GameObject SecondContent;
    public GameObject FirstQuestionBox;
    public GameObject SecondQuestionBox;
    public GameObject ThirdQuestionBox;
    public GameObject FirstAnswerRight;
    public GameObject FirstAnswerWrong;
    public GameObject ThirdAnswerRight;
    public GameObject ThirdAnswerWrong;
    public GameObject TipsWindows;

    public FirstTopic FirstTopic;
    public ThirdTopic ThirdTopic;
    public FourthTopic FourthTopic;
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
    public Text FifthText;
    public CanvasGroup FirstQuestionBoxCanvasGroup;
    public CanvasGroup ThirdQuestionBoxCanvasGroup;
    public Button TopicButton;
    public Button NextTopicButton;
    public Button SecondToThirdTopicButton;
    public Image image;

    //�½ڰ�ť�Ƿ񱻵��
    public bool isCall;

    //ÿһ���Ƿ��ύ
    public bool isSubmitFirst;
    public bool isSubmitSecond;

    private void Start()
    {
        isCall = false;
        isSubmitFirst = false;
        isSubmitSecond = false;
    }
    private void Update()
    {
        if (GlobalVariables.isFinishSecond == 2)
        {
            GlobalVariables.SecondTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
            GlobalVariables.isFinishSecond++;
            GlobalVariables.SecondTime = (int)(GlobalVariables.SecondTimeOver - GlobalVariables.SecondTimeBegin);
        }

        if(!isCall)
        {
            GlobalVariables.SecondTimeBegin = ChangeTime.Changetime(DateTime.Now.ToString());
            GlobalVariables.SecondTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
        }

        if(isCall &&(!isSubmitFirst || !isSubmitSecond))
        {
            GlobalVariables.SecondTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
        }
    }

    #region �½���ת
    public void OnSecondTopicButtonClick()
    {
        FirstTopic.FirstContent.SetActive(false);
        ThirdTopic.ThirdContent.SetActive(false);
        FourthTopic.FourthContent.SetActive(false);
        FifthTopic.FifthContent.SetActive(false);
        SixthTopic.SixthContent.SetActive(false);
        SeventhTopic.SeventhContent.SetActive(false);
        EighthTopic.EighthContent.SetActive(false);
        NinthTopic.NinthContent.SetActive(false);
        TenthTopic.TenthContent.SetActive(false);
        EleventhTopic.EleventhContent.SetActive(false);
        SecondContent.SetActive(true);

        image.color = new Color(0, 0, 0);
        FirstTopic.image.color = new Color(255, 255, 255);
        ThirdTopic.image.color = new Color(255, 255, 255);
        FourthTopic.image.color = new Color(255, 255, 255);
        FifthTopic.image.color = new Color(255, 255, 255);
        SixthTopic.image.color = new Color(255, 255, 255);
        SeventhTopic.image.color = new Color(255, 255, 255);
        EighthTopic.image.color = new Color(255, 255, 255);
        NinthTopic.image.color = new Color(255, 255, 255);
        TenthTopic.image.color = new Color(255, 255, 255);
        EleventhTopic.image.color = new Color(255, 255, 255);

        if (!isCall)
        {
            GlobalVariables.SecondTimeBegin = ChangeTime.Changetime(DateTime.Now.ToString());
            isCall = true;
        }
    }
    #endregion

    #region ��Ŀ�ύ
    public void OnFirstSubmitButtonClick()
    {
        FirstQuestionBoxCanvasGroup.interactable = false;
        
        if(FirstText.text == "" || SecondText.text == "" || ThirdText.text == "")
        {
            TipsWindows.SetActive(true);
        }
        else
        {
            if ((FirstText.text == "������" && SecondText.text == "������" && ThirdText.text == "�źŴ���") ||
                        (FirstText.text == "������" && SecondText.text == "�źŴ���" && ThirdText.text == "������") ||
                        (FirstText.text == "������" && SecondText.text == "������" && ThirdText.text == "�źŴ���") ||
                        (FirstText.text == "������" && SecondText.text == "�źŴ���" && ThirdText.text == "������") ||
                        (FirstText.text == "�źŴ���" && SecondText.text == "������" && ThirdText.text == "������") ||
                        (FirstText.text == "�źŴ���" && SecondText.text == "������" && ThirdText.text == "������"))
            {
                FirstAnswerRight.SetActive(true);
                if(!isSubmitFirst)
                {
                    GlobalVariables.score += 6;
                    GlobalVariables.SecondScore += 6;
                    GlobalVariables.isFinishSecond++;
                    isSubmitFirst = true;
                }
            }
            else
            {
                FirstAnswerWrong.SetActive(true);
                if (!isSubmitFirst)
                {
                    GlobalVariables.isFinishSecond++;
                    isSubmitFirst = true;
                }
            }
        }
    }

    public void OnSecondSubmitButtonClick()
    {
        ThirdQuestionBoxCanvasGroup.interactable = false;
        if (FourthText.text == "" || FifthText.text == "")
        {
            TipsWindows.SetActive(true);
        }
        else
        {
            if (FourthText.text.Contains("���ű���") && FourthText.text.Contains("�����")  && FifthText.text.Contains("ת����") && FifthText.text.Contains("�����"))
            {
                ThirdAnswerRight.SetActive(true);
                if(!isSubmitSecond)
                {
                    GlobalVariables.score += 4;
                    GlobalVariables.SecondScore += 4;
                    GlobalVariables.isFinishSecond++;
                    isSubmitSecond = true;
                }
            }
            else
            {
                ThirdAnswerWrong.SetActive(true);
                if (!isSubmitSecond)
                {
                    GlobalVariables.isFinishSecond++;
                    isSubmitSecond = true;
                }
            }
        }
    }
    #endregion

    #region ��Ŀ��ת
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
}
