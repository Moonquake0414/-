using System;
using UnityEngine;

public class OverTime : MonoBehaviour
{
    public void GetCurrentTime()
    {
        DateTime localTime = DateTime.Now;
        GlobalVariables.endTime = ChangeTime.Changetime(localTime.ToString());//����ʱ��endTime������

        //�������ʱ��ʱֱ�Ӽ������ʱ��
        GlobalVariables.operateTime = (int)(GlobalVariables.endTime - GlobalVariables.satrtTime);//�������ʱ��operateTime������
    }
}
