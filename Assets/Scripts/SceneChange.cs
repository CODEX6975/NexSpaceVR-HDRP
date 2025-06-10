using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("White Room");
    }
}
