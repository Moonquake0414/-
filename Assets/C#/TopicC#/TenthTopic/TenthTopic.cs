using System;
using UnityEngine;
using UnityEngine.UI;

public class TenthTopic : MonoBehaviour
{
    public GameObject TenthContent;
    public GameObject FirstQuestionBox;

    public FirstTopic FirstTopic;
    public SecondTopic SecondTopic;
    public ThirdTopic ThirdTopic;
    public FourthTopic FourthTopic;
    public FifthTopic FifthTopic;
    public SixthTopic SixthTopic;
    public SeventhTopic SeventhTopic;
    public EighthTopic EighthTopic;
    public NinthTopic NinthTopic;
    public EleventhTopic EleventhTopic;
    public Button TopicButton;
    public Image image;

    //章节按钮是否被点击
    public bool isCall;

    //章节结束时间是否记录
    public static bool isRecord;

    private void Start()
    {
        isCall = false;
        isRecord = true;
    }

    void Update()
    {
        if (isCall && image.color.r == 255 && image.color.g == 255 && image.color.b == 255 && isRecord)
        {
            GlobalVariables.TenthTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
            GlobalVariables.TenthTime = (int)(GlobalVariables.TenthTimeOver - GlobalVariables.TenthTimeBegin);
            if(GlobalVariables.TenthTime < 1)
            {
                GlobalVariables.TenthTime = 1;
            }
            isRecord = false;
        }

        if(!isCall)
        {
            GlobalVariables.TenthTimeBegin = ChangeTime.Changetime(DateTime.Now.ToString());
            GlobalVariables.TenthTimeOver = ChangeTime.Changetime(DateTime.Now.ToString());
        }
    }

    #region 章节跳转
    public void OnTenthTopicButtonClick()
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
        EleventhTopic.EleventhContent.SetActive(false);
        TenthContent.SetActive(true);

        image.color = new Color(0, 0, 0);
        SecondTopic.image.color = new Color(255, 255, 255);
        ThirdTopic.image.color = new Color(255, 255, 255);
        FourthTopic.image.color = new Color(255, 255, 255);
        FifthTopic.image.color = new Color(255, 255, 255);
        SixthTopic.image.color = new Color(255, 255, 255);
        SeventhTopic.image.color = new Color(255, 255, 255);
        EighthTopic.image.color = new Color(255, 255, 255);
        NinthTopic.image.color = new Color(255, 255, 255);
        FirstTopic.image.color = new Color(255, 255, 255);
        EleventhTopic.image.color = new Color(255, 255, 255);

        if (!isCall)
        {
            GlobalVariables.TenthTimeBegin = ChangeTime.Changetime(DateTime.Now.ToString());
            isCall = true;
        }
    }
    #endregion
}
