using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UnitFormation : MonoBehaviour
    {
    public GameObject commander;
    public Vector3 currentCommanderPos;
    private float zc;
    private float xc;
    private float xsq;
    private float zsq;

    private float soldierCount;

    public bool isCPressed = false;
    public bool isFPressed = false;
    public bool isOPressed = false;

    public float smoothTime = 0.6F;
    private Vector3 velocity = Vector3.zero;

    void Start()
        {

        }

    // Update is called once per frame
    void Update()
        {
        OrderFormation();
        }

    void OrderFormation()
        {

        Sample();

        if (Input.GetKey(KeyCode.C))
            {
            isCPressed = true;
            isFPressed = false;
            isOPressed = false;
            }
                if (isCPressed)
                    {
                    //SingleColumn();
                    }
                        if (Input.GetKey(KeyCode.F))
                            {
                            isFPressed = true;
                            isCPressed = false;
                            isOPressed = false;
                            }
                                if (isFPressed)
                                    {
                                    //FormUp();
                                    }
                                            if (Input.GetKey(KeyCode.O))
                                                {
                                                isOPressed = true;
                                                isFPressed = false;
                                                isCPressed = false;
                                                }
                                                        if (isOPressed)
                                                            {
                                                            //Square();
                                                            }
        }

    void Sample()
        {
        if (Input.GetKey(KeyCode.P))
            {
            ListofNavMeshes.Instance.moveForward();
            }
        
        }

    //void FormUp()
    //    {
    //    commander.transform.position = currentCommanderPos;
    //    //zc = 3.0f;
    //    foreach (var item in ListofNavMeshes.Instance.agentsList)
    //        {
    //        item.transform.position = Vector3.SmoothDamp(item.transform.localPosition, currentCommanderPos, ref velocity, smoothTime);
    //        zc = zc - 3.0f;
    //        currentCommanderPos = new Vector3(0, 1.0f, zc);
    //        }
    //    }

    //void SingleColumn()
    //    {
    //    commander.transform.position = currentCommanderPos;
    //    zc = -0.75f;
    //    foreach (var item in ListofNavMeshes.Instance.agentsList)
    //        {
    //        item.transform.localPosition = Vector3.MoveTowards(item.transform.localPosition, currentCommanderPos, Time.deltaTime / 4);
    //        zc = zc - 0.75f;
    //        currentCommanderPos = new Vector3(0, 1.5f, zc);
    //        }
    //    }

    //void FiringLine()
    //    {
    //    commander.transform.position = currentCommanderPos;
    //    xc = -0.75f;
    //    foreach (var item in ListofNavMeshes.Instance.agentsList)
    //        {
    //        item.transform.localPosition = Vector3.MoveTowards(item.transform.localPosition, currentCommanderPos, Time.deltaTime / 4);
    //        xc = xc - 0.75f;
    //        currentCommanderPos = new Vector3(xc, 1.5f, 0);
    //        }
    //    }

    //#region Square

    //private void MakeSquare()
    //    {
    //    xsq = 1.0f;
    //    zsq = 1;
    //    soldierCount = ListofNavMeshes.Instance.agentsList.Count / 2;
    //    for (int i = 0; i < soldierCount; i++)
    //        {
    //        ListofNavMeshes.Instance.agentsList[i].transform.localPosition = Vector3.MoveTowards(ListofNavMeshes.Instance.agentsList[i].transform.localPosition, currentCommanderPos, Time.deltaTime);
    //        xsq += xsq;
    //        currentCommanderPos = new Vector3(xsq, 1.5f, zsq);
    //        }
    //    }

    //private void Square()
    //    {
    //    xsq = 2.5f;
    //    zsq = 2.5f;

    //    for (int i = 0; i < 5; i++)
    //        {
    //        zsq = 1;
    //        ListofNavMeshes.Instance.agentsList[i].transform.localPosition = Vector3.MoveTowards(ListofNavMeshes.Instance.agentsList[i].transform.localPosition, currentCommanderPos, Time.deltaTime);
    //        xsq = xsq + 1.5f;
    //        zsq = zsq - 2;
    //        currentCommanderPos = new Vector3(xsq, 0.5f, zsq);
    //        }

    //    for (int i = 5; i < 8; i++)
    //        {
    //        xsq = currentCommanderPos.x;
    //        zsq = 1.0f;
    //        ListofNavMeshes.Instance.agentsList[i].transform.localPosition = Vector3.MoveTowards(ListofNavMeshes.Instance.agentsList[i].transform.localPosition, currentCommanderPos, Time.deltaTime);
    //        xsq = xsq + 1.5f;
    //        zsq = zsq - 2;
    //        currentCommanderPos = new Vector3(xsq, 0.5f, zsq);
    //        }
    //    for (int i = 9; i < 12; i++)
    //        {
    //        xsq = currentCommanderPos.x;
    //        zsq = 1.0f;
    //        ListofNavMeshes.Instance.agentsList[i].transform.localPosition = Vector3.MoveTowards(ListofNavMeshes.Instance.agentsList[i].transform.localPosition, currentCommanderPos, Time.deltaTime);
    //        xsq = xsq + 1.5f;
    //        zsq = zsq - 2;
    //        currentCommanderPos = new Vector3(xsq, 0.5f, zsq);
    //        }
    //    }
    //#endregion


    }
