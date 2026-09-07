using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsManage : MonoBehaviour
{
    public GameSettingsSO settings;
    public static SettingsManage Instance;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadSettings();
        ApplyAllSettings();
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetFloat("MasterVolume", settings.MasterVolume);
        PlayerPrefs.SetFloat("MusicVolume", settings.MusicVolume);
        PlayerPrefs.SetFloat("SFXVolume", settings.SFXVolume);
        PlayerPrefs.SetInt("ResolutionWidth", settings.ResolutionWidth);
        PlayerPrefs.SetInt("ResolutionHeight", settings.ResolutionHeight);
        PlayerPrefs.SetInt("IsFullscreen", settings.IsFullscreen ? 1 : 0);
        PlayerPrefs.SetFloat("MouseSensitivity", settings.MouseSensitivity);
        PlayerPrefs.SetInt("InvertYAxis", settings.InvertYAxis ? 1 : 0);
        PlayerPrefs.Save();
    }

    public void LoadSettings()
    {
        settings.MasterVolume = PlayerPrefs.GetFloat("MasterVolume", settings.MasterVolume);
        settings.MusicVolume = PlayerPrefs.GetFloat("MusicVolume", settings.MusicVolume);
        settings.SFXVolume = PlayerPrefs.GetFloat("SFXVolume", settings.SFXVolume);
        settings.ResolutionWidth = PlayerPrefs.GetInt("ResolutionWidth", settings.ResolutionWidth);
        settings.ResolutionHeight = PlayerPrefs.GetInt("ResolutionHeight", settings.ResolutionHeight);
        settings.IsFullscreen = PlayerPrefs.GetInt("IsFullscreen", settings.IsFullscreen ? 1 : 0) == 1;
        settings.MouseSensitivity = PlayerPrefs.GetFloat("MouseSensitivity", settings.MouseSensitivity);
        settings.InvertYAxis = PlayerPrefs.GetInt("InvertYAxis", settings.InvertYAxis ? 1 : 0) == 1;
    }

    public void ApplyAllSettings()
    {
        Screen.fullScreen = settings.IsFullscreen;
        Screen.SetResolution(settings.ResolutionWidth, settings.ResolutionHeight, settings.IsFullscreen);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void SetMasterVolume(float value) 
    { 
        settings.MasterVolume = value; 
        ApplyAllSettings(); 
        SaveSettings(); 
    }

    public void SetMusicVolume(float value) { 
        settings.MusicVolume = value; 
        ApplyAllSettings(); 
        SaveSettings(); 
    }

    public void SetSFXVolume(float value) { 
        settings.SFXVolume = value; 
        ApplyAllSettings(); 
        SaveSettings(); 
    }

    public void SetFullscreen(bool value) { 
        settings.IsFullscreen = value; 
        ApplyAllSettings(); 
        SaveSettings(); 
    }

    public void SetResolution(int width, int height) { 
        settings.ResolutionWidth = width; 
        settings.ResolutionHeight = height; 
        ApplyAllSettings(); 
        SaveSettings(); 
    }

    public void SetResolution1920x1080() { 
        SetResolution(1920, 1080); 
    }

    public void SetResolution1280x720() { 
        SetResolution(1280, 720); 
    }

    public void SetResolution640x720() { 
        SetResolution(640, 720); 
    }

    public void SetSensitivity(float value) { 
        settings.MouseSensitivity = value; 
        SaveSettings(); 
    }

    public void SetInvertY(bool value) { 
        settings.InvertYAxis = value; 
        SaveSettings(); 
    }
}