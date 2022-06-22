using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ListofNavMeshes : MonoBehaviour
    {
    public List<GameObject> agentsList = new List<GameObject>();

    public static ListofNavMeshes _instance;
    public static ListofNavMeshes Instance
        {
        get
            {
            return _instance;
            }
        }
    private void Awake()
        {
            if (_instance != null && Instance != gameObject)
                {
                Destroy(gameObject);
                }
            else
                {
                _instance = this;
                }
        }

    public void moveForward()
        {
        this.transform.Translate(Vector3.forward);
        }
    }
