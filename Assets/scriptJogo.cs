using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptJogo : MonoBehaviour
{
    public void comecar () {
        SceneManager.LoadScene(1);
    }

    public void menuInicial () {
        SceneManager.LoadScene(0);
    }
    
    public void sair() {
        Application.Quit();
    }
}
