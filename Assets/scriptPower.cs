using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPower : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter (Collider other) {
        if (other.tag == "Player") {
            scriptJogador.vel += 2;
            scriptJogador.rotMouseX += 4;
            scriptCamera.rotMouseY += 4;
            Destroy(gameObject);
        }
    }
}

