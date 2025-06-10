using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirdTopic : MonoBehaviour
{
    public GameObject ThirdContent;
    public GameObject FirstQuestionBox;
    public GameObject SecondQuestionBox;
    public GameObject ThirdQuestionBox;
    public GameObject FourthQuestionBox;
    public GameObject FourthAnswerRight;
    public GameObject FourthAnswerWrong;
    public GameObject TipsWindows;

    public FirstTopic FirstTopic;
    public SecondTopic SecondTopic;
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
    public Toggle FirstToggle;
    public Toggle SecondToggle;
    public Toggle ThirdToggle;
    public Toggle FourthToggle;
    public Toggle FifthToggle;
    public Toggle SixthToggle;
    public Toggle SeventhToggle;
    public Toggle EighthToggle;
    public CanvasGroup FourthQuestionBoxCanvasGroup;
    public Button TopicButton;
    public Button ThirdToFourthTopicButton;
    public Image image;

    //�½ڰ�ť�Ƿ񱻵��
    public bool isCall;

    //ÿһ���Ƿ��ύ
    public bool isSubmitFirst;

    private void Start()
    {
        isCall = false;
        isSubmitFirst = false;
    }

    private void Update()
    {
        if (GlobalVariables.isFinishThird == 1)
        {
            GlobalVariables.ThirdTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
            GlobalVariables.isFinishThird++;
            GlobalVariables.ThirdTime = (int)(GlobalVariables.ThirdTimeOver - GlobalVariables.ThirdTimeBegin);
            Debug.Log(GlobalVariables.ThirdTime);
        }

        if (!isCall)
        {
            GlobalVariables.ThirdTimeBegin = ChangeTime.Changetime(DateTime.Now.ToString());
            GlobalVariables.ThirdTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
        }

        if (isCall && !isSubmitFirst)
        {
            GlobalVariables.ThirdTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
        }
    }

    #region �½���ת
    public void OnThirdTopicButtonClick()
    {
        FirstTopic.FirstContent.SetActive(false);
        SecondTopic.SecondContent.SetActive(false);
        FourthTopic.FourthContent.SetActive(false);
        FifthTopic.FifthContent.SetActive(false);
        SixthTopic.SixthContent.SetActive(false);
        SeventhTopic.SeventhContent.SetActive(false);
        EighthTopic.EighthContent.SetActive(false);
        NinthTopic.NinthContent.SetActive(false);
        TenthTopic.TenthContent.SetActive(false);
        EleventhTopic.EleventhContent.SetActive(false);
        ThirdContent.SetActive(true);

        image.color = new Color(0, 0, 0);
        SecondTopic.image.color = new Color(255, 255, 255);
        FirstTopic.image.color = new Color(255, 255, 255);
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
            GlobalVariables.ThirdTimeBegin = ChangeTime.Changetime(DateTime.Now.ToString());
            isCall = true;
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

    #region ��Ŀ�ύ
    public void OnFourthSubmitButtonClick()
    {
        FourthQuestionBoxCanvasGroup.interactable = false;
        
        if(FirstText.text == "" || SecondText.text == "" || (!FirstToggle.isOn && !SecondToggle.isOn && !ThirdToggle.isOn
            && !FourthToggle.isOn) || (!FifthToggle.isOn && !SixthToggle.isOn && !SeventhToggle.isOn && !EighthToggle.isOn))
        {
            TipsWindows.SetActive(true);
        }
        else
        {
            bool FirstContent = false;
            bool SecondContent = false;
            bool ThirdContent = false;
            if ((FirstText.text == "����ѹ��" && SecondText.text == "����ѹ��") || (FirstText.text == "����ѹ��" && SecondText.text == "����ѹ��"))
            {
                FirstContent = true;
            }
            else
            {
                FirstContent = false;
            }

            if (FirstToggle.isOn && SecondToggle.isOn && ThirdToggle.isOn && FourthToggle.isOn)
            {
                SecondContent = true;
            }
            else
            {
                SecondContent = false;
            }

            if (FifthToggle.isOn && SixthToggle.isOn && SeventhToggle.isOn && EighthToggle.isOn)
            {
                ThirdContent = true;
            }
            else
            {
                ThirdContent = false;
            }

            if (FirstContent && SecondContent && ThirdContent)
            {
                FourthAnswerRight.SetActive(true);
                if(!isSubmitFirst)
                {
                    GlobalVariables.score += 10;
                    GlobalVariables.ThirdScore += 10;
                    GlobalVariables.isFinishThird++;
                    isSubmitFirst = true;
                }            
            }
            else
            {
                FourthAnswerWrong.SetActive(true);
                if (!isSubmitFirst)
                {
                    GlobalVariables.isFinishThird++;
                    isSubmitFirst = true;
                }
            }
        }
    }
    #endregion
}
