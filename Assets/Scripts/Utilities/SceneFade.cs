using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneFade : MonoBehaviour
{
    /*Содержит методы управления анимацией затеменения экрана при переходе между сценами.
     Содержит событие, вызывающееся при окончании анимации, которое осуществляет непосредственно переход на указанную сцену.
     */

    [SerializeField] private Animator animator;
    private int levelToLoad;

    private void Awake()
    {
        GetComponent<Image>().enabled = true;
    }

    public void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("Fade Out");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
