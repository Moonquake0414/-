using System;
using UnityEngine;

public class ChangeTime : MonoBehaviour
{
    public static long Changetime(string NeedChangeTmie)
    {
        string dateTimeString = NeedChangeTmie;
        // ������ַ���ת����DateTime����
        DateTime yourDate = DateTime.Parse(dateTimeString);

        // �����Ļ����Ǳ���ʱ�䣬������Ҫ����UTCʱ���������Ҫ��ת����UTC
        // ����Ѿ���UTCʱ�䣬�����ֱ��ת��
        DateTime utcDate = yourDate.ToUniversalTime();

        // ��ȡUnixʱ�������1970-01-01 00:00:00 UTC��ʼ���㣩
        long unixTimestamp = ((DateTimeOffset)utcDate).ToUnixTimeSeconds();

        // ���10λʱ���
        return unixTimestamp;
    }
}