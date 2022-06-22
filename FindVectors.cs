using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FindVectors : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject commander;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Seek(Vector3 location)
        {
        agent.SetDestination(location);
        }

    void Flee(Vector3 location)
        {
        Vector3 fleeTarget = location + this.transform.position;
        agent.SetDestination(this.transform.position - fleeTarget);
        }
        
    void Pursue()
            {
            Vector3 targetDir = commander.transform.position - agent.transform.position;

        float relativeHeading = Vector3.Angle(this.transform.forward, this.transform.TransformVector(commander.transform.forward));
        float toTarget = Vector3.Angle(this.transform.forward, this.transform.TransformVector(targetDir));

                if ((toTarget > 90 && relativeHeading < 20) || commander.GetComponent<Drive>().currentSpeed < 0.01f)
                            {
                                Seek(commander.transform.position);
                                return;
                            }

            float lookAhead = targetDir.magnitude / agent.speed * (commander.GetComponent<Drive>().currentSpeed);
            Seek(commander.transform.position + commander.transform.forward * lookAhead);
            }
    // Update is called once per frame
    void Update()
    {
        //Pursue();
        Seek(commander.transform.position);
    }
}
