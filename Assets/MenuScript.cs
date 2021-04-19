using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void PlayGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public GameObject mainMenu;
    public GameObject creditMenu;

    public void Credits() {
        mainMenu.SetActive(false);
        creditMenu.SetActive(true);
    }

    public void Back() {
        mainMenu.SetActive(true);
        creditMenu.SetActive(false);
    }

    public void QuitGame() {
        Application.Quit();
    }
}
