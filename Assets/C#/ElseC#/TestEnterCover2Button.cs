using UnityEngine;
using UnityEngine.SceneManagement;

public class TestEnterCover2Button : MonoBehaviour
{
     public void OnReturnButton()
     {
        SceneManager.LoadScene("001-Cover2");
     }
}
