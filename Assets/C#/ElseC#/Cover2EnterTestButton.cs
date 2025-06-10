using UnityEngine;
using UnityEngine.SceneManagement;

public class Cover2EnterTestButton : MonoBehaviour
{
    public void OnButtonClick()
    {
        SceneManager.LoadScene("002-Test");
    }
}
