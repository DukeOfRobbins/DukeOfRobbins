using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Agents : MonoBehaviour
{
    private void Start()
        {
        ListofNavMeshes.Instance.agentsList.Add(gameObject);
        
        }
    private void Update()
        {
        
        }
    }
