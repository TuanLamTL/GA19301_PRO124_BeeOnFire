using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject SettingsPanel;
    public GameObject LevelMapPanel;
    public void LoadLevelMapDay()
    {
        SceneManager.LoadScene("Day");
    }

    public void LoadLevelMapNight()
    {
        SceneManager.LoadScene("Night");
    }

    public void LoadLevelMapFog()
    {
        SceneManager.LoadScene("Fog");
    }

    void Start()
    {
        SettingsPanel.SetActive(false); // Paneli baþlangýçta devre dýþý býrak
    }

    public void OpenSettingsPanel()
    {
        SettingsPanel.SetActive(true);
    }
    public void CloseSettingsPanel()
    {
        SettingsPanel.SetActive(false);
    }

    public void OpenLevelMapPanel()
    {
        LevelMapPanel.SetActive(true);
    }

    public void CloseLevelMapPanel()
    {
        LevelMapPanel.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit(); // Oyunu kapat
    }

    public void Setaudio(float value)
    {
        AudioListener.volume = value;
    }
}
