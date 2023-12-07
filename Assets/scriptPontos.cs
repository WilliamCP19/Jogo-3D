using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class scriptPontos : MonoBehaviour
{
    public TextMeshProUGUI textoPlacar;
    private static int placar = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter (Collider other) {
        placar += 1; Destroy(gameObject, 1);
    }

    // Update is called once per frame
    void Update()
    {
        textoPlacar.text = "Placar: " + placar;
        if (placar == 30) {
            SceneManager.LoadScene(2);
        }
    }
}
