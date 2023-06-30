using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalScript : MonoBehaviour
{
    [SerializeField] private string MainScene;
    [SerializeField] private GameObject MenuPrincipal;
    [SerializeField] private GameObject MenuInstrucoes;
    public void Iniciar(){
        SceneManager.LoadScene(MainScene);
    }

    public void Instrucoes(){
        MenuPrincipal.SetActive(false);
        MenuInstrucoes.SetActive(true);
    }

    public void sairInstrucoes(){
        MenuInstrucoes.SetActive(false);
        MenuPrincipal.SetActive(true);
    }

    public void Sair(){
        Debug.Log("Saiu do jogo");
        Application.Quit();
    }
}
