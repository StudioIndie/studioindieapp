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
    void Update()//Função para atualização do alpha do fade de acordo com a booleana ativada. 
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
                ChangeScene();
            }
        }
    }
    void ChangeScene()//Função de controle de cenas.
    {
        SceneManager.LoadScene(newScene);
    }
    public void ToMenu()
    {
        fadeOut = true;
        newScene = "Menu";
    }
    public void ToModes()
    {
        fadeOut = true;
        newScene = "Mods";
    }
    public void ToAbout()
    {
        fadeOut = true;
        newScene = "About";
    }
    public void ToProfessions()
    {
        fadeOut = true;
        newScene = "Professions";
    }
    public void ToRules()
    {
        fadeOut = true;
        newScene = "Rules";
    }
	public void ToAR()
    {
        fadeOut = true;
        newScene = "AR";
    }
    public void ToDynamic()
    {
        fadeOut = true;
        newScene = "Dynamic";
    }
}
