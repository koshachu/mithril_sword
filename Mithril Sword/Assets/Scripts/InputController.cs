using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class InputController : MonoBehaviour
{
    public Transform TargetTransform;
    public NavMeshAgent PlayerAgent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.name == "Enemy")
                {
                    PlayerAgent.destination = hit.collider.transform.position;
                }
                else
                {
                    TargetTransform.transform.position = hit.point;
                    PlayerAgent.destination = hit.point;
                }   
            }
        }
        
    }
}
