using UnityEngine;

[CreateAssetMenu(fileName = "GameSettings", menuName = "Settings/Game Settings")]
public class GameSettingsSO : ScriptableObject
{
    [Header("Audio")]
    public float MasterVolume = 1f;
    public float MusicVolume = 0.8f;
    public float SFXVolume = 0.8f;

    [Header("Video")]
    public int ResolutionWidth = 1920;
    public int ResolutionHeight = 1080;
    public bool IsFullscreen = true;

    [Header("Controls")]
    public float MouseSensitivity = 1f;
    public bool InvertYAxis = false;
}