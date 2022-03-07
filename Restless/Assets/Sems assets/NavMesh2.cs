using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NavMesh2 : MonoBehaviour
{
    public Vector3 dir;
    public Transform player;
    public RaycastHit hit;
    public float angle;
    public NavMeshAgent navMeshAgent;
    public Vector3 walkDir;
    public float distance;
    public Transform[] target;
    public bool idle;
    public int currentTargetIndex;
    public float inRange;

    public void Start()
    {

        
        idle = true;
        currentTargetIndex = 0;
        inRange = 3;
    }

    public void Update()
    {
        distance = Vector3.Distance(player.position, transform.position);
        
        
        dir = player.position - transform.position;
        
        angle = Vector3.Angle(dir, transform.forward);

        if (Physics.Raycast(transform.position, dir, out hit, 30f))
        {
            if (hit.transform.gameObject.name == ("Player"))
            {
                
                if (angle < 90f)
                {
                    idle = false;
                    if (idle == false)
                    {
                        transform.LookAt(player);
                        navMeshAgent.destination = player.position;
                        
                    }
                    else
                    {
                        currentTargetIndex = 1;
                    }
                }
            }
            else
            {
                idle = true;

            }
        }
       

        Debug.DrawRay(transform.position, dir, Color.blue);

        if(idle == true)
        {
            navMeshAgent.destination = target[currentTargetIndex].position;
            transform.LookAt(target[currentTargetIndex].position);
        }
        if (Vector3.Distance(transform.position, target[currentTargetIndex].position) < inRange)
        {
            currentTargetIndex++;

        }

        if (currentTargetIndex == target.Length)
        {
            currentTargetIndex = 0;
        }







    }


 

}











