using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeMale : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("White Room_male");
    }
}
