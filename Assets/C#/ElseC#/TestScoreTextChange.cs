using UnityEngine;
using UnityEngine.UI;

public class TestScoreTextChange : MonoBehaviour
{
    public Text NeedChangeText;

    void Start()
    {
        TextChange();
    }

    public void TextChange()
    {
        NeedChangeText.text = "当前分数：" + GlobalVariables.score;
    }
}
