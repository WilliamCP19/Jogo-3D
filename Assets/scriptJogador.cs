using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptJogador : MonoBehaviour
{
    float moveFrente, moveLado;
    public static float rotMouseX = 0;
    public Rigidbody rbd;
    public static int vel = 5;
    private Quaternion rotOriginal, lado;
    private bool pausado = false;
    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody>();
        rotOriginal = transform.localRotation;
    }
    // Update is called once per frame
    void Update()
    {
        moveFrente = Input.GetAxis("Vertical");
        moveLado = Input.GetAxis("Horizontal");

        Vector3 velocidade = transform.TransformDirection (new Vector3 (moveLado * vel, rbd.velocity.y, moveFrente * vel));
        rbd.velocity = velocidade;

        rotMouseX += Input.GetAxis("Mouse X");
        lado = Quaternion.AngleAxis(rotMouseX, Vector3.up);
        transform.localRotation = rotOriginal * lado;

        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (pausado) {
                Time.timeScale = 1;
                SceneManager.UnloadScene(0);
            } else {
                Time.timeScale = 0;
                SceneManager.LoadScene(0, LoadSceneMode.Additive);
            }
            pausado = !pausado;
        }
    }
}