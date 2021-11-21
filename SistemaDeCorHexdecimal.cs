using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SistemaDeCorHexdecimal : MonoBehaviour
{
    #region <Variaveis>
    //Objeto aonde sera pego o componente de Imagem.Color e trocara para uma cor especifica.
    public GameObject Objeto;

    //Lista de cores em hexdecimal #xxxxxx.
    public List<string> Paleta;
    
    //Botoes que Troca de cor.
    public Button btn_rgb_1, btn_rgb_2, btn_rgb_3;
    #endregion
    
//Ao comecar a rodar utiliza o roteiro a baixo.
    void Start()
    {
        #region <Declara os botoes e seus parametros>
        btn_rgb_1.onClick.AddListener(() => TrocaCor(Paleta[0]));
        btn_rgb_2.onClick.AddListener(() => TrocaCor(Paleta[1]));
        btn_rgb_3.onClick.AddListener(() => TrocaCor(Paleta[2]));
        #endregion
    }

//Função que troca a cor do objeto.
    public void TrocaCor(string HexCor)
    {
        Color cor;
        ColorUtility.TryParseHtmlString(HexCor, out cor);
        Objeto.GetComponent<Image>().color = cor;
    }
}
#region <Feito por>
/*

Instagram
    @amonelderlich
    @cassianozacarias

Discord
    https://discord.gg/GV2S2Qu3vB

*/
#endregion