using System;
using UnityEngine;
using UnityEngine.UI;

public class EleventhTopic : MonoBehaviour
{
    public GameObject EleventhContent;
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
    public EighthTopic EighthTopic;
    public NinthTopic NinthTopic;
    public TenthTopic TenthTopic;

    public CanvasGroup ThirdQuestionBoxCanvasGroup;
    public Button TopicButton;
    public Text FirstText;
    public Text SecondText;
    public Image image;

    //�½ڰ�ť�Ƿ񱻵��
    public bool isCall;

    //ÿһ���Ƿ��ύ
    public bool isSubmitFirst;

    //�ֲ��÷�
    public int PerScore;

    private void Start()
    {
        isCall = false;
        isSubmitFirst = false;
        PerScore = 0;
    }

    private void Update()
    {
        if (GlobalVariables.isFinishEleventh == 1)
        {
            GlobalVariables.EleventhTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
            GlobalVariables.isFinishEleventh++;
            GlobalVariables.EleventhTime = (int)(GlobalVariables.EleventhTimeOver - GlobalVariables.EleventhTimeBegin);
        }

        if (!isCall)
        {
            GlobalVariables.EleventhTimeBegin = ChangeTime.Changetime(DateTime.Now.ToString());
            GlobalVariables.EleventhTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
        }

        if (isCall && !isSubmitFirst)
        {
            GlobalVariables.EleventhTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
        }
    }

    #region �½���ת
    public void OnEleventhTopicButtonClick()
    {
        FirstTopic.FirstContent.SetActive(false);
        SecondTopic.SecondContent.SetActive(false);
        ThirdTopic.ThirdContent.SetActive(false);
        FourthTopic.FourthContent.SetActive(false);
        FifthTopic.FifthContent.SetActive(false);
        SixthTopic.SixthContent.SetActive(false);
        SeventhTopic.SeventhContent.SetActive(false);
        EighthTopic.EighthContent.SetActive(false);
        NinthTopic.NinthContent.SetActive(false);
        TenthTopic.TenthContent.SetActive(false);
        EleventhContent.SetActive(true);

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
        FirstTopic.image.color = new Color(255, 255, 255);

        if (!isCall)
        {
            GlobalVariables.EleventhTimeBegin = ChangeTime.Changetime(DateTime.Now.ToString());
            isCall = true;
        }
    }
    #endregion
    
    #region ��Ŀ��ת
    public void SecondQuestionToThirdQuestion()
    {
        SecondQuestionBox.SetActive(false);
        ThirdQuestionBox.SetActive(true);
    }

    public void ThirdQuestionReturnSecondQuestion()
    {
        SecondQuestionBox.SetActive(true);
        ThirdQuestionBox.SetActive(false);
    }
    #endregion

    #region ��Ŀ�ύ
    public void OnThirdSubmitButtonClick()
    {
        ThirdQuestionBoxCanvasGroup.interactable = false;
        if (FirstText.text == "" || SecondText.text == "")
        {
            TipsWindows.SetActive(true);
        }
        else
        {
            if (FirstText.text.Contains("����"))
            {
                PerScore++;
            }
            if (FirstText.text.Contains("�ӿ�"))
            {
                PerScore++;
            }
            if (FirstText.text.Contains("��λ"))
            {
                PerScore++;
            }
            if (FirstText.text.Contains("���"))
            {
                PerScore++;
            }
            if (FirstText.text.Contains("�������"))
            {
                PerScore++;
            }

            if (SecondText.text.Contains("����"))
            {
                PerScore++;
            }
            if (SecondText.text.Contains("��ɫ����"))
            {
                PerScore++;
            }
            if (SecondText.text.Contains("��ɫ�ռ�"))
            {
                PerScore++;
            }
            if (SecondText.text.Contains("ת��"))
            {
                PerScore++;
            }
            if (SecondText.text.Contains("YUV"))
            {
                PerScore++;
            }

            if (!isSubmitFirst)
            {
                isSubmitFirst = true;
                GlobalVariables.isFinishEleventh++;
                GlobalVariables.score += PerScore;
                GlobalVariables.EleventhScore += PerScore;
            }

            if (PerScore == 10)
            {
                ThirdAnswerRight.SetActive(true);
                PerScore = 0;
            }
            else
            {
                ThirdAnswerWrong.SetActive(true);
                PerScore = 0;
            }
        }
    }
    #endregion
}
