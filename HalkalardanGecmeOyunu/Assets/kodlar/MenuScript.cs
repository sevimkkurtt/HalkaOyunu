using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void PlayButton()
    {


       
        SceneManager.LoadScene(0);
    }

    public void QuitButton()
    {
#if UNITY_EDITOR
        // Unity Editor'da �al���rken oyunu "sonland�rmak" i�in
        UnityEditor.EditorApplication.isPlaying = false;
#else
        
        Application.Quit();
#endif
    }

    public void LevelButton()
    {
        SceneManager.LoadScene(2);
    }
}
