using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Main Menu
    public void PlayGame()
    {
        SceneManager.LoadScene("Level Select");
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }

    //Level Select- 1 Levels
    public void NextPage2Button()
    {
        SceneManager.LoadScene("Level Select 2");
    }
    public void BackToPage1Button()
    {
        SceneManager.LoadScene("Level Select");
    }
    public void Level1Button()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void Level2Button()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void Level3Button()
    {
        SceneManager.LoadScene("Level 3");
    }
    public void Level4Button()
    {
        SceneManager.LoadScene("Level 4");
    }
    public void Level5Button()
    {
        SceneManager.LoadScene("Level 5");
    }
    public void Level6Button()
    {
        SceneManager.LoadScene("Level 6");
    }
    public void Level7Button()
    {
        SceneManager.LoadScene("Level 7");
    }
    public void Level8Button()
    {
        SceneManager.LoadScene("Level 8");
    }
    //Level Select- 2 -level select -tablita cu carucioru de cumparaturi + si i
    public void ShopButton()
    {
        SceneManager.LoadScene("Shop");
    }
    public void ShopBackButton()
    {
        SceneManager.LoadScene("Level Select");
    }
    public void MoreButton()
    {
        SceneManager.LoadScene("More");
    }
    public void MoreBackButton()
    {
        SceneManager.LoadScene("Level Select");
    }
    public void InfoButton()
    {
        SceneManager.LoadScene("Info");
    }
    public void InfoBackButton()
    {
        SceneManager.LoadScene("Level Select");
    }
}
