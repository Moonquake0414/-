using UnityEngine;

public class TestIsFinish : MonoBehaviour
{
    public void TestisFinish()
    {
        if (GlobalVariables.isFinishFirst == 3 && GlobalVariables.isFinishSecond == 3 && GlobalVariables.isFinishThird == 2 && GlobalVariables.isFinishFourth == 2
            && GlobalVariables.isFinishFifth == 2 && GlobalVariables.isFinishSixth == 4 && GlobalVariables.isFinishSeventh == 2 && GlobalVariables.isFinishEighth == 2
            && GlobalVariables.isFinishNinth == 5 && GlobalVariables.isFinishEleventh == 2)
        {
            GlobalVariables.isFinish = 1;
        }
    }

}
