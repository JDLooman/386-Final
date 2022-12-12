using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public List<GameObject> wayPoints;

    NavMeshAgent agent;

    public int dest = 0;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = wayPoints[dest].transform.position;
        if(Vector3.Distance(agent.transform.position, wayPoints[dest].transform.position) < 10)
        {
            Debug.Log("we are here");
            dest++;
            if(dest == wayPoints.Count)
            {
                dest = 0;
            }
        }
    }
}
