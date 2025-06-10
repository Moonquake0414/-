using System;
using UnityEngine;

public class ChangeTime : MonoBehaviour
{
    public static long Changetime(string NeedChangeTmie)
    {
        string dateTimeString = NeedChangeTmie;
        // 将你的字符串转换成DateTime对象
        DateTime yourDate = DateTime.Parse(dateTimeString);

        // 如果你的环境是本地时间，而你需要的是UTC时间戳，则需要先转换到UTC
        // 如果已经是UTC时间，则可以直接转换
        DateTime utcDate = yourDate.ToUniversalTime();

        // 获取Unix时间戳（从1970-01-01 00:00:00 UTC开始计算）
        long unixTimestamp = ((DateTimeOffset)utcDate).ToUnixTimeSeconds();

        // 输出10位时间戳
        return unixTimestamp;
    }
}