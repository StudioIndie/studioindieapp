using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour 
{
    private GameObject fade;
    private byte a;
    public string newScene;
    public bool fadeIn;
    public bool fadeOut;

    void Start()
    {
        fadeIn = true;
        fade = GameObject.Find("Fade");
        a = 255;
    }

    /// <summary>
    /// No Update realiza algoritmo para atualização do alfa do fade de acordo com a booleana ativada.
    /// </summary>
    void Update() 
    {
        if (fadeIn)
        {
            fade.GetComponent<Renderer>().material.color = new Color32((byte)Color.black.r, (byte)Color.black.g, (byte)Color.black.b, a);
            if (a > 0)
            {
                a -= 17;
            }
            else
            {
                fadeIn = false;
                fade.SetActive(false);
            }
        }
        else if (fadeOut)
        {
            fade.SetActive(true);
            fade.GetComponent<Renderer>().material.color = new Color32((byte)Color.black.r, (byte)Color.black.g, (byte)Color.black.b, a);
            if (a < 255)
            {
                a += 17;
            }
            else
            {
                LoadScene();
            }
        }
    }
    /// <summary>
    /// Método que faz o carregamento das cenas
    /// </summary>
    void LoadScene()
    {
        SceneManager.LoadScene(newScene);
    }

    /// <summary>
    /// Método que faz a escolha das cenas
    /// </summary>
    /// <param name="scene">Recebe o nome da cena</param>
    public void ChangeScene(string scene)
    {
        fadeOut = true;
        newScene = scene;
    }
}
