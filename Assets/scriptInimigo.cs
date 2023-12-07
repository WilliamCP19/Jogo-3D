using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
public class scriptInimigo : MonoBehaviour
{
    private NavMeshAgent agente;
    public GameObject player;
    public float maxDistAlvo = 20;
    
     //Start is called before the first frame update
    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
    }

    private void OnTriggerEnter (Collider hit) {
        if (hit.tag == "Player") {
            SceneManager.LoadScene(2);
        }
    }
     //Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < maxDistAlvo) {
            agente.SetDestination(player.transform.position);
        }
    }
}
