using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeFemale : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("White Room_female");
    }
}
