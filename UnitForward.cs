using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitForward : MonoBehaviour
{
    SelectAnObject selectAnObject;
    public Transform target;
    Vector3 currentPos;
    float step = 1.0f;
    private Vector3 velocity = Vector3.zero;

    private void Start()
        {
        selectAnObject = GetComponent<SelectAnObject>();
        }
    private void Update()
        {
        moveForward();
        }

    void moveForward()
        {
        currentPos = selectAnObject.currentlySelected.transform.position;
        if (Input.GetMouseButton(0))
            {
            selectAnObject.currentlySelected.transform.position = Vector3.SmoothDamp(currentPos, target.transform.position, ref velocity,1.0f);
            }
        }
    }
