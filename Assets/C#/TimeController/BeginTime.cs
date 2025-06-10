using System;
using UnityEngine;

public class BeginTime : MonoBehaviour
{
    public void GetCurrentTime()
    {
        DateTime localTime = DateTime.Now;
        GlobalVariables.satrtTime = ChangeTime.Changetime(localTime.ToString());//开始时间satrtTime被重置
        Debug.Log("当前系统时间222: " + GlobalVariables.satrtTime);

        //重置每个章节是否完成变量
        ResetIsFinish();

        //重置实验总分数以及每个章节的小分
        ResetPerScore();

        //重置每个章节的开始时间
        ResetPerBeginTime();

        //重置每个章节的结束时间
        ResetPerOverTime();

        //重置每个章节用时
        ResetnTime();

        //重置实验报告
        GlobalVariables.projectReport = "";
    }

    public void ResetIsFinish()
    {
        GlobalVariables.isFinishFirst = 0;
        GlobalVariables.isFinishSecond = 0;
        GlobalVariables.isFinishThird = 0;
        GlobalVariables.isFinishFourth = 0;
        GlobalVariables.isFinishFifth = 0;
        GlobalVariables.isFinishSixth = 0;
        GlobalVariables.isFinishSeventh = 0;
        GlobalVariables.isFinishEighth = 0;
        GlobalVariables.isFinishNinth = 0;
        GlobalVariables.isFinishEleventh = 0;
    }

    public void ResetPerScore()
    {
        GlobalVariables.score = 0;
        GlobalVariables.FirstScore = 0;
        GlobalVariables.SecondScore = 0;
        GlobalVariables.ThirdScore = 0;
        GlobalVariables.FourthScore = 0;
        GlobalVariables.FifthScore = 0;
        GlobalVariables.SixthScore = 0;
        GlobalVariables.SeventhScore = 0;
        GlobalVariables.EighthScore = 0;
        GlobalVariables.NinthScore = 0;
        GlobalVariables.TenthScore = 0;
        GlobalVariables.EleventhScore = 0;
    }

    public void ResetPerBeginTime()
    {
        GlobalVariables.SecondTimeBegin = 0;
        GlobalVariables.ThirdTimeBegin = 0;
        GlobalVariables.FourthTimeBegin = 0;
        GlobalVariables.FifthTimeBegin = 0;
        GlobalVariables.SixthTimeBegin = 0;
        GlobalVariables.SeventhTimeBegin = 0;
        GlobalVariables.EighthTimeBegin = 0;
        GlobalVariables.NinthTimeBegin = 0;
        GlobalVariables.TenthTimeBegin = 0;
        GlobalVariables.EleventhTimeBegin = 0;
    }

    public void ResetPerOverTime()
    {
        GlobalVariables.FirstTimeOver = 0;
        GlobalVariables.SecondTimeOver = 0;
        GlobalVariables.ThirdTimeOver = 0;
        GlobalVariables.FourthTimeOver = 0;
        GlobalVariables.FifthTimeOver = 0;
        GlobalVariables.SixthTimeOver = 0;
        GlobalVariables.SeventhTimeOver = 0;
        GlobalVariables.EighthTimeOver = 0;
        GlobalVariables.NinthTimeOver = 0;
        GlobalVariables.TenthTimeOver = 0;
        GlobalVariables.EleventhTimeOver = 0;
    }

    public void ResetnTime()
    {
        GlobalVariables.SecondTime = 0;
        GlobalVariables.ThirdTime = 0;
        GlobalVariables.FourthTime = 0;
        GlobalVariables.FifthTime = 0;
        GlobalVariables.SixthTime = 0;
        GlobalVariables.SeventhTime = 0;
        GlobalVariables.EighthTime = 0;
        GlobalVariables.NinthTime = 0;
        GlobalVariables.TenthTime = 0;
        GlobalVariables.EleventhTime = 0;
    }
}
