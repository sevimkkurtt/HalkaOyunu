using UnityEngine;

public class Ptusu : MonoBehaviour
{
    private bool isPaused = false; 

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();
        }
    }

    void TogglePause()
    {
        if (isPaused)
        {
            
            Time.timeScale = 1f; 
            isPaused = false; 
        }
        else
        {
            // Oyunu duraklat
            Time.timeScale = 0f; 
            isPaused = true; 
        }
    }
}

