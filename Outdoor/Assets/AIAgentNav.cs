using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class AIAgentNav : MonoBehaviour
{

    private NavMeshAgent agent;

    [SerializeField] Transform startPoint;
    [SerializeField] Transform endPoint;

    private bool isAtStart;


    // Start is called before the first frame update
    void Start()
    {
        
        agent = GetComponent<NavMeshAgent>();
        isAtStart = true;
    }

    // Update is called once per frame
    void Update()
    {
        CheckState();

        if (isAtStart)
        {
            agent.destination = endPoint.position;
        } else
        {
            agent.destination = startPoint.position;

        }

    }

    public void CheckState()
    {
        if (this.transform.position.x == endPoint.position.x && this.transform.position.z == endPoint.position.z)
        {
            isAtStart = false;
        }
        else if (this.transform.position.x == startPoint.position.x && this.transform.position.z == startPoint.position.z)
        {
            isAtStart = true;
        }
    }

}
