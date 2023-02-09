using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpcoes;

   public void LoadScene(int indexScene)
   {
    SceneManager.LoadScene(indexScene);
   }
    
    public void AbriOpcoes()
   {
    painelMenuInicial.SetActive(false);
    painelOpcoes.SetActive(true);
   }

   public void FecharOpcoes()
   {
    painelOpcoes.SetActive(false);
    painelMenuInicial.SetActive(true);

   }

   public void ExitGame()
   {
    Application.Quit();
    Debug.Log("SAINDO DO JOGO");
   }
}