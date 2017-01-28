using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Classe criada para simular o efeito do botão return android utilizando um input da teclaa ESCAPE ESC
/// </summary>
public class Functions : MonoBehaviour
{
    public string scene;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(scene);
        }
    }
}
