using System.Collections.Generic;
using UnityEngine;

public class UnitSelections : MonoBehaviour
{
    public List<GameObject> unitList = new List<GameObject>();
    public List<GameObject> unitsSelected = new List<GameObject>();

    public static UnitSelections _instance;
    public static UnitSelections Instance 
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

    public void ClickSelect(GameObject unitToAdd)
        {
        DeselectAll();
        unitsSelected.Add(unitToAdd);
        // Highlight Object
        unitToAdd.transform.GetChild(0).gameObject.SetActive(true);
        unitToAdd.GetComponent<UnitMovement>().enabled = true;
        }

    public void ShiftClickToSelect(GameObject unitToAdd)
        {
        if (!unitsSelected.Contains(unitToAdd))
            {
            unitsSelected.Add(unitToAdd);
            // Highlight Object
            unitToAdd.transform.GetChild(0).gameObject.SetActive(true);
            unitToAdd.GetComponent<UnitMovement>().enabled = true;
             }
        else
            {
            unitToAdd.transform.GetChild(0).gameObject.SetActive(false);
            unitToAdd.GetComponent<UnitMovement>().enabled = false;
            unitsSelected.Remove(unitToAdd);
            }
        }

    public void DragSelect(GameObject unitToAdd)
        {
        if (!unitsSelected.Contains(unitToAdd))
            {
            unitsSelected.Add(unitToAdd);
            // Highlight Object
            unitToAdd.transform.GetChild(0).gameObject.SetActive(true);                                
            unitToAdd.GetComponent<UnitMovement>().enabled = true;
            }
        }
    public void DeselectAll()
        {
        foreach (var unit in unitsSelected)
            {
                unit.GetComponent<UnitMovement>().enabled = false;
                unit.transform.GetChild(0).gameObject.SetActive(false);
            }
        unitsSelected.Clear();
        }
    }
