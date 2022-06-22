using UnityEngine;
using System.Collections.Generic;
using UnityEngine.AI;

public class UnitMovement : MonoBehaviour
    {
    Camera myCam;
    NavMeshAgent myAgent;
    public LayerMask ground;

    RaycastHit hit;

    void Start()
        {
        myCam = Camera.main;
        myAgent = GetComponent<NavMeshAgent>();
        }

    // Update is called once per frame
    void Update()
        {
        moveAgent();
        }

    void moveAgent()
        {
        if (Input.GetMouseButton(1))
            {
            Ray ray = myCam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, ground))
                {
                if (myAgent.name == "Commander")
                    {
                    myAgent.SetDestination(hit.point);

                    }
                if (myAgent.name == "Private")
                    {
                    myAgent.SetDestination(hit.point);
                    }
                }
            }
        }
    }


