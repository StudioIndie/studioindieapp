using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Profissao : MonoBehaviour
{
    public static int idProfissao;
    public Color[] coresProfissoes;
    public Sprite[] personagensProfissoes;
    private static string[] tituloProfissao = new string[] { "Programador", "Roteirista", "Freelancer", "Artista", "Produtor", "GameDesigner" };
    public Image personagem;
    public Text resumoProfissao;
    public Text profissao;
    Camera camera;

    private static string[] fraseProfissao = new string[]{
      "Tem como objetivo dar vida ao jogo, pondo em pratica as ideias do Game Designer. Normalmente utiliza de engines como Unity e Unreal.",
      "É aquele quem idealiza, normalmente junto ao Game Designer, todo o ambiente e a historia do jogo.",
      "Esse tem como objetivo resolver pequenos problemas na linha de produção, e normalmente é chamado quando a equipe do jogo nao consegue realizar algo. Pode, as vezes, passar a integrar a equipe original.",
      "É o responsavel pelo audiovisual. Tem como objetivo criar todo o mundo do jogo. Normalmente utiliza dos programas adobe como Illustrator e Photoshop.",
      "É o cara quem cuida da parte financeira do projeto. É responsavel por fornecer as ferramentas necessarias para a produçao do jogo e por (Re)vende-lo.",
      "Seu principal objetivo é pensar nas mecanicas que o jogo levará e todos os desafios que o jogador pode enfrentar. Seu objetivo secundário é complicar a vida do programador."
    };

    void Start()
    {
        personagem.sprite = personagensProfissoes[idProfissao];
        profissao.text = tituloProfissao[idProfissao].ToUpper();
        resumoProfissao.text = fraseProfissao[idProfissao].ToUpper();
        camera = GetComponent<Camera>();
        camera.backgroundColor = coresProfissoes[idProfissao];
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Professions");
        }
    }
}
