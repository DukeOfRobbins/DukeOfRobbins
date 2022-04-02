using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectAnObject : MonoBehaviour
    {
    public Transform objHoveredOver;
    public Transform currentlySelected;

    public Material objSelectedColor;
    public Material originalObjColor;
    
    private void Update()
        {
        UnselectObj();
        SelectObj();
        }
    public void SelectObj()
        {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit objectPointedAt;

        if (Physics.Raycast(ray, out objectPointedAt, 1500))
            {
            
            objHoveredOver = objectPointedAt.transform;
            if (Input.GetMouseButton(0))
                {
                if (objHoveredOver.transform.CompareTag("Selectable"))
                    {
                    originalObjColor = objHoveredOver.GetComponent<Renderer>().material;
                    objHoveredOver.GetComponent<Renderer>().material = objSelectedColor;
                    currentlySelected = objHoveredOver.transform;
                    }
                }         
             }
        
            }
    private void UnselectObj()
        {
        if (Input.GetMouseButton(0))  // Left mousebutton selected
            {
                if (currentlySelected != null)
                        {
                        if (currentlySelected.transform.CompareTag("Selectable"))
                                {
                                currentlySelected.GetComponent<Renderer>().material = originalObjColor;
                                currentlySelected = null;
                                }
                        }
            }
        }
   }
