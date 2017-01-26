using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProfissaoMenu : MonoBehaviour
{
	public void escolherProfissao(int idProfissao)
    {
        Profissao.idProfissao = idProfissao;    
        SceneManager.LoadScene("profession");    
    }
}
