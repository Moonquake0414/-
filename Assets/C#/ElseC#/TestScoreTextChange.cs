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
        NeedChangeText.text = "��ǰ������" + GlobalVariables.score;
    }
}
