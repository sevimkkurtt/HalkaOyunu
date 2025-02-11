using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int Skor;
    public Text SkorText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void gameScore(int halkaSkor)
    {
        Skor += halkaSkor;
       SkorText.text = Skor.ToString();
    }



    public void RestartGame() 
    {
        SceneManager.LoadScene(0);
    }

    public void Leveliki()
    {
        SceneManager.LoadScene(1);
    }

}
