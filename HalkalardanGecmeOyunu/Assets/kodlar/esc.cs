using UnityEngine;
using UnityEngine.SceneManagement; 

public class esc : MonoBehaviour
{
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            LoadMenuScene();
        }
    }

    private void LoadMenuScene()
    {
        
        SceneManager.LoadScene("Menu"); 
        
    }
}
