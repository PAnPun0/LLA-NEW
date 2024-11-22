using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    //загрузить уровень
    public void PlayGame()
    { 
        SceneManager.LoadScene(1); 
    }
    
    //выйти из игры
    public void QuitGame()
    {
        Application.Quit();
    }

    //Продолжить
    public void Continue()
    { 
        SceneManager.LoadScene(1); 
    }

    public void Continue2()
    { 
        SceneManager.LoadScene(2); 
    }
    
    public void Continue3()
    { 
        SceneManager.LoadScene(3); 
    }

}
