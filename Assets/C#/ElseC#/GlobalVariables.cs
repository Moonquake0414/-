using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    //实验总分数
    public static int score = 0;

    //实验是否完成
    public static int isFinish = 0;

    //实验总耗时
    public static int operateTime = 0;

    //实验身份验证相关信息
    public static string bearerToken;
    public static string ticket;
    public static string signature;
    public static string userAccount;
    public static string userName;

    //实验报告内容
    public static string projectReport = "";

    //实验开始时间
    public static long satrtTime = 0;

    //实验结束时间（POST时间）
    public static long endTime = 0;

    //每个章节是否完成
    public static int isFinishFirst = 0;//2题
    public static int isFinishSecond = 0;//2题
    public static int isFinishThird = 0;//1题
    public static int isFinishFourth = 0;//1题
    public static int isFinishFifth = 0;//1题
    public static int isFinishSixth = 0;//1题
    public static int isFinishSeventh = 0;//1题
    public static int isFinishEighth = 0;//1题
    public static int isFinishNinth = 0;//1题
    public static int isFinishEleventh = 0;//1题

    //每个章节完成时间
    public static int FirstTime = 0;
    public static int SecondTime = 0;
    public static int ThirdTime = 0;
    public static int FourthTime = 0;
    public static int FifthTime = 0;
    public static int SixthTime = 0;
    public static int SeventhTime = 0;
    public static int EighthTime = 0;
    public static int NinthTime = 0;
    public static int TenthTime = 0;
    public static int EleventhTime = 0;

    //每个章节结束时间
    public static long FirstTimeOver = 0;
    public static long SecondTimeOver = 0;
    public static long ThirdTimeOver = 0;
    public static long FourthTimeOver = 0;
    public static long FifthTimeOver = 0;
    public static long SixthTimeOver = 0;
    public static long SeventhTimeOver = 0;
    public static long EighthTimeOver = 0;
    public static long NinthTimeOver = 0;
    public static long TenthTimeOver = 0;
    public static long EleventhTimeOver = 0;

    //每个章节开始时间
    //public static long FirstTimeBegin = 0; //第一章节自动开始，开始时间即为实验开始时间
    public static long SecondTimeBegin =  0;
    public static long ThirdTimeBegin = 0;
    public static long FourthTimeBegin = 0;
    public static long FifthTimeBegin = 0;
    public static long SixthTimeBegin = 0;
    public static long SeventhTimeBegin = 0;
    public static long EighthTimeBegin = 0;
    public static long NinthTimeBegin = 0;
    public static long TenthTimeBegin = 0;
    public static long EleventhTimeBegin = 0;

    //每个章节分数
    public static int FirstScore = 0;
    public static int SecondScore = 0;
    public static int ThirdScore = 0;
    public static int FourthScore = 0;
    public static int FifthScore = 0;
    public static int SixthScore = 0;
    public static int SeventhScore = 0;
    public static int EighthScore = 0;
    public static int NinthScore = 0;
    public static int TenthScore = 0;
    public static int EleventhScore = 0;
}
