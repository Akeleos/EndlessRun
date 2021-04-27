using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuPanel;
    public bool escapePanel ;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenuPanel = GameObject.FindWithTag("PauseMenu");
    }

    // Update is called once per frame
    void Update()
    {
        Pause();
    }

    public void Pause()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            escapePanel = !escapePanel; 
        }
        if(escapePanel)
        {
            Time.timeScale = 0;
            pauseMenuPanel.SetActive(escapePanel);
        }
        else
        {
            Time.timeScale = 1;
            pauseMenuPanel.SetActive(escapePanel);
        }
    }

    public void Resume()
    {
        Time.timeScale = 1;
        escapePanel = !escapePanel;
        pauseMenuPanel.SetActive(escapePanel);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }

    public void backToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
