using UnityEngine;

public class Unit : MonoBehaviour
{
    void Start()
    {
        UnitSelections.Instance.unitList.Add(gameObject);
    }
}
