using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PainelMenuInicial : MonoBehaviour
{
    public void IniciarJogo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void SairDoJogo()
    {
        Application.Quit();
        Debug.Log("Saiu do Jogo");
    }
}
