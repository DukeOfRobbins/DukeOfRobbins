using UnityEngine;

public class UnitDrag : MonoBehaviour
{

    Camera myCam;

    [SerializeField]
    RectTransform boxVisual;

    Rect SelectionBox;

    Vector2 startPosition;
    Vector2 endPosition;
    // Start is called before the first frame update
    void Start()
    {
        myCam = Camera.main;
        startPosition = Vector2.zero;
        endPosition = Vector2.zero;
        DrawVisual();
    }

    // Update is called once per frame
    void Update()
    {
        // when clicked

        if (Input.GetMouseButtonDown(0))
            {
            startPosition = Input.mousePosition;
            SelectionBox = new Rect();
            }

        // when dragging

        if (Input.GetMouseButton(0))
            {
            endPosition = Input.mousePosition;
            DrawVisual();
            DrawSelection();
            }

        // when release click

        if (Input.GetMouseButtonUp(0))
            {
            SelectUnits();
            startPosition = Vector2.zero;
            endPosition = Vector2.zero;
            DrawVisual();
            }
        }
    void DrawVisual()
    {
        Vector2 boxStart = startPosition;
        Vector2 boxEnd = endPosition;

        Vector2 boxCenter = (boxStart + boxEnd) / 2;
        boxVisual.position = boxCenter;

        Vector2 boxSize = new Vector2(Mathf.Abs(boxStart.x - boxEnd.x), Mathf.Abs(boxStart.y - boxEnd.y));

        boxVisual.sizeDelta = boxSize;
    }

    void DrawSelection()
        {
        // draw x calculations
        if (Input.mousePosition.x < startPosition.x)
            {
            // dragging left
            SelectionBox.xMin = Input.mousePosition.x;
            SelectionBox.xMax = startPosition.x;
            }
        else
            {
            // dragging right
            SelectionBox.xMin = startPosition.x;
            SelectionBox.xMax = Input.mousePosition.x;
            }
        if (Input.mousePosition.y < startPosition.y)
            {
            // dragging down
            SelectionBox.yMin = Input.mousePosition.y;
            SelectionBox.yMax = startPosition.y;
            }
        else
            {
            // dragging up
            SelectionBox.yMin = startPosition.y;
            SelectionBox.yMax = Input.mousePosition.y;
            }


        }

    void SelectUnits()
        {
        foreach (var unit in UnitSelections.Instance.unitList)
            {
            if (SelectionBox.Contains(myCam.WorldToScreenPoint(unit.transform.position)))
                {
                UnitSelections.Instance.DragSelect(unit);
                }
            }
        }


}
