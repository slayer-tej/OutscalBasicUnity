using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OnClick : MonoBehaviour
{
    public Button button;
    public string Scene2;


    private void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }
    private void OnButtonClick()
    {
        Debug.Log("Button Clicked");
        SceneManager.LoadScene(Scene2);
    }
}