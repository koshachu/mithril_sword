using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    private NavMeshAgent playerAgent;
    void Start()
    {
        playerAgent = GetComponent<NavMeshAgent>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Enemy")
        {
            playerAgent.isStopped = true;
        }

    }

}
