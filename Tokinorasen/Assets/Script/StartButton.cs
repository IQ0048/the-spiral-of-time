using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
    }

    public void OnClick()
    {
        SceneManager.LoadScene("Game");
    }
}