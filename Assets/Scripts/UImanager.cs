using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
    public GameObject mainMenuCanvas;
    public GameObject narrationCanvas;
    public GameObject creditsCanvas;
    public GameObject settingsCanvas;
    public PlayableDirector timeline;

    [Header("Scene Names")]
    public string maleNarrationSceneName;
    public string femaleNarrationSceneName;

    void Start()
    {
        mainMenuCanvas.SetActive(true);
        narrationCanvas.SetActive(false);

        Time.timeScale = 0f;

        if (timeline != null)
            timeline.Pause(); // Manually pause the timeline
    }
    public void OnCreditsButtonPressed()
    {
        // Switch to credits choice screen
        mainMenuCanvas.SetActive(false);
        creditsCanvas.SetActive(true);
    }
    public void OnSettingsButtonPressed()
    {
        // Switch to Settings choice screen
        mainMenuCanvas.SetActive(false);
        settingsCanvas.SetActive(true);
    }
    public void OnStartButtonPressed()
    {
        // Switch to narration choice screen
        mainMenuCanvas.SetActive(false);
        narrationCanvas.SetActive(true);
    }

    public void OnChooseMaleNarration()
    {
        ResumeAndLoadScene(maleNarrationSceneName);
    }

    public void OnChooseFemaleNarration()
    {
        ResumeAndLoadScene(femaleNarrationSceneName);
    }

    private void ResumeAndLoadScene(string sceneName)
    {
        Time.timeScale = 1f;

        if (timeline != null)
            timeline.Resume();

        if (!string.IsNullOrEmpty(sceneName))
            SceneManager.LoadScene(sceneName);
        else
            Debug.LogError("Scene name is empty! Assign it in the Inspector.");
    }
    public void OnQuitButtonPressed()
    {
#if UNITY_EDITOR
        // Stop play mode if running in the editor
        UnityEditor.EditorApplication.isPlaying = false;
#else
    // Quit application if running as a built game
    Application.Quit();
#endif
    }

}
