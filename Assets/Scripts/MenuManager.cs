using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void IrAjustes()
    {
        SceneManager.LoadScene("Settings");
    }

    public void IrCreditos()
    {
        SceneManager.LoadScene("Credits");
    }

    public void VolverMenu() { 
        SceneManager.LoadScene("Menu"); 
    }

    public void Salir()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                Application.Quit();
        #endif
    }
}