using System;
using UnityEngine;

public class OverTime : MonoBehaviour
{
    public void GetCurrentTime()
    {
        DateTime localTime = DateTime.Now;
        GlobalVariables.endTime = ChangeTime.Changetime(localTime.ToString());//结束时间endTime被重置

        //算出结束时间时直接计算过程时间
        GlobalVariables.operateTime = (int)(GlobalVariables.endTime - GlobalVariables.satrtTime);//计算过程时间operateTime被重置
    }
}
