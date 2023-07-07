using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    /*Скрипт кнопки главного меню.*/

    [SerializeField] GameObject sceneFadeContainer;
    private SceneFade fade;

    private void Awake()
    {
        fade = sceneFadeContainer.GetComponent<SceneFade>();
    }

    public void LoadGalleryBtn()
    {
        fade.FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
