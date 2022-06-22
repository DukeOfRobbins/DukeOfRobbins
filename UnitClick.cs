using UnityEngine;

public class UnitClick : MonoBehaviour
{

    private Camera myCam;
    public static GameObject target;

    public LayerMask clickable;
    public LayerMask ground;

    void Start()
    {
        myCam = Camera.main;
        }
    void Update()
    {
        if (Input.GetMouseButton(0))
            {
            RaycastHit hit;

            Ray ray = myCam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, clickable))
                {
                if (Input.GetKey(KeyCode.LeftShift))
                    {
                    UnitSelections.Instance.ShiftClickToSelect(hit.collider.gameObject);
                    }
                else
                    {
                    UnitSelections.Instance.ClickSelect(hit.collider.gameObject);
                    }
                }
            else
                {
                if (!Input.GetKey(KeyCode.LeftShift))
                    {
                    UnitSelections.Instance.DeselectAll();
                    }
                
                }
            }
    }
}
