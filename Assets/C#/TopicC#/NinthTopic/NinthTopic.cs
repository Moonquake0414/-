using System;
using UnityEngine;
using UnityEngine.UI;

public class NinthTopic : MonoBehaviour
{
    public GameObject TeacherStarTalk;
    public GameObject NinthContent;
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
    public SixthTopic SixthTopic;
    public SeventhTopic SeventhTopic;
    public EighthTopic EighthTopic;
    public TenthTopic TenthTopic;
    public EleventhTopic EleventhTopic;
    public Text FirstText;
    public Text SecondText;
    public Text ThirdText;
    public Text FourthText;
    public CanvasGroup SecondQuestionBoxCanvasGroup;
    public Button TopicButton;
    public Button NitnthToTenthTopicButton;
    public Image image;

    //�½ڰ�ť�Ƿ񱻵��
    public bool isCall;

    //ÿһ���Ƿ��ύ
    public bool isSubmitFirst;

    //��һ�����ÿһС���Ƿ��ύ
    public bool isSubmitFirstProblem;
    public bool isSubmitSecondProblem;
    public bool isSubmitThirdProblem;
    public bool isSubmitFourthProblem;

    //��һ�����ÿһС���Ƿ���ȷ
    public bool FirstContent;
    public bool SecondContent;
    public bool ThirdContent;
    public bool FourthContent;

    private void Start()
    {
        isCall = false;
        isSubmitFirst = false;
        isSubmitFirstProblem = false;
        isSubmitSecondProblem = false;
        isSubmitThirdProblem = false;
        isSubmitFourthProblem = false;
        FirstContent = false;
        SecondContent = false;
        ThirdContent = false;
        FourthContent = false;
    }

    private void Update()
    {
        if (GlobalVariables.isFinishNinth == 1)
        {
            GlobalVariables.NinthTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
            GlobalVariables.isFinishNinth++;
            GlobalVariables.NinthTime = (int)(GlobalVariables.NinthTimeOver - GlobalVariables.NinthTimeBegin);
        }

        if (!isCall)
        {
            GlobalVariables.NinthTimeBegin = ChangeTime.Changetime(DateTime.Now.ToString());
            GlobalVariables.NinthTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
        }

        if (isCall && !isSubmitFirst)
        {
            GlobalVariables.NinthTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
        }
    }

    #region �½���ת
    public void OnNinthTopicButtonClick()
    {
        FirstTopic.FirstContent.SetActive(false);
        SecondTopic.SecondContent.SetActive(false);
        ThirdTopic.ThirdContent.SetActive(false);
        FourthTopic.FourthContent.SetActive(false);
        FifthTopic.FifthContent.SetActive(false);
        SixthTopic.SixthContent.SetActive(false);
        SeventhTopic.SeventhContent.SetActive(false);
        EighthTopic.EighthContent.SetActive(false);
        TenthTopic.TenthContent.SetActive(false);
        EleventhTopic.EleventhContent.SetActive(false);
        NinthContent.SetActive(true);

        image.color = new Color(0, 0, 0);
        SecondTopic.image.color = new Color(255, 255, 255);
        ThirdTopic.image.color = new Color(255, 255, 255);
        FourthTopic.image.color = new Color(255, 255, 255);
        FifthTopic.image.color = new Color(255, 255, 255);
        SixthTopic.image.color = new Color(255, 255, 255);
        SeventhTopic.image.color = new Color(255, 255, 255);
        EighthTopic.image.color = new Color(255, 255, 255);
        FirstTopic.image.color = new Color(255, 255, 255);
        TenthTopic.image.color = new Color(255, 255, 255);
        EleventhTopic.image.color = new Color(255, 255, 255);

        if (!isCall)
        {
            GlobalVariables.NinthTimeBegin = ChangeTime.Changetime(DateTime.Now.ToString());
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

    public void SecondQuestionReturnFirstQuestion()
    {
        FirstQuestionBox.SetActive(true);
        SecondQuestionBox.SetActive(false);
    }
    #endregion

    #region ��Ŀ�ύ
    public void OnSecondSubmitButtonClick()
    {
        SecondQuestionBoxCanvasGroup.interactable = false;
        if (FirstText.text == "" || SecondText.text == "" || ThirdText.text == "" || FourthText.text == "")
        {
            TipsWindows.SetActive(true);
        }
        else
        {
            if (FirstText.text.Contains("��ȥ") && FirstText.text.Contains("�ź���ֵ")) /*&& SecondText.text == "Ԥ��ֵ" 
                && (ThirdText.text == "��ʵ��ֵ" || ThirdText.text == "��ʵֵ" || ThirdText.text == "��ʵֵ" || ThirdText.text == "��ʵ��ֵ") 
                && FourthText.text == "��ֵ")*/
            {
                //SecondAnswerRight.SetActive(true);
                FirstContent = true;
                //if (!isSubmitFirst)
                //{
                //    GlobalVariables.score += 16;
                //    GlobalVariables.NinthScore += 16;
                //    GlobalVariables.isFinishNinth++;
                //    isSubmitFirst = true;
                //}
                if (!isSubmitFirstProblem)
                {
                    GlobalVariables.score += 4;
                    GlobalVariables.NinthScore += 4;
                    GlobalVariables.isFinishNinth++;
                    isSubmitFirstProblem = true;
                }

            }
            else
            {
                //SecondAnswerWrong.SetActive(true);
                //if (!isSubmitFirst)
                //{
                //    GlobalVariables.isFinishNinth++;
                //    isSubmitFirst = true;
                //}
                FirstContent = false;
                if (!isSubmitFirstProblem)
                {
                    GlobalVariables.isFinishNinth++;
                    isSubmitFirstProblem = true;
                }
            }

            if (SecondText.text == "Ԥ��ֵ")
            {
                SecondContent = true;
                if (!isSubmitSecondProblem)
                {
                    GlobalVariables.score += 4;
                    GlobalVariables.NinthScore += 4;
                    GlobalVariables.isFinishNinth++;
                    isSubmitSecondProblem = true;
                }
            }
            else
            {
                SecondContent = false;
                if (!isSubmitSecondProblem)
                {
                    GlobalVariables.isFinishNinth++;
                    isSubmitSecondProblem = true;
                }
            }

            if (ThirdText.text == "��ʵ��ֵ" || ThirdText.text == "��ʵֵ" 
                || ThirdText.text == "��ʵֵ" || ThirdText.text == "��ʵ��ֵ")
            {
                ThirdContent = true;
                if (!isSubmitThirdProblem)
                {
                    GlobalVariables.score += 4;
                    GlobalVariables.NinthScore += 4;
                    GlobalVariables.isFinishNinth++;
                    isSubmitThirdProblem = true;
                }
            }
            else
            {
                ThirdContent = false;
                if (!isSubmitThirdProblem)
                {
                    GlobalVariables.isFinishNinth++;
                    isSubmitThirdProblem = true;
                }
            }

            if (FourthText.text == "��ֵ")
            {
                FourthContent = true;
                if (!isSubmitFourthProblem)
                {
                    GlobalVariables.score += 4;
                    GlobalVariables.NinthScore += 4;
                    GlobalVariables.isFinishNinth++;
                    isSubmitFourthProblem = true;
                }
            }
            else
            {
                FourthContent = false;
                if (!isSubmitFourthProblem)
                {
                    GlobalVariables.isFinishNinth++;
                    isSubmitFourthProblem = true;
                }
            }

            if (FirstContent && SecondContent && ThirdContent && FourthContent)
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
