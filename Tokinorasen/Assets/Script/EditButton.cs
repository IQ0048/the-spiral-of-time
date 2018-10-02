using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EditButton : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
    }

    public void OnClick()
    {
        SceneManager.LoadScene("Edit");
    }
}