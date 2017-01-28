using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProfissaoMenu : MonoBehaviour
{
    /// <summary>
    /// Método para saber qual botão de profissão foi tocado e assim carregar corretamente a cena seguinte
    /// </summary>
    /// <param name="idProfissao">Rece um ID da profissão para ser utilizado na próxima cena</param>
	public void escolherProfissao(int idProfissao)
    {
        Profissao.idProfissao = idProfissao;    
        SceneManager.LoadScene("profession");    
    }
}
