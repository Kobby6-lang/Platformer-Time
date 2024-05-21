using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortfolioMain : MonoBehaviour
{
   public void LoadMainMenu(string MainMenu) 
   {
        SceneManager.LoadScene(MainMenu);
   }
}
