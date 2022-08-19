using UnityEngine;
using UnityEngine.EventSystems;

public class BallController : Figures, IDragHandler
{
    private int offset = 2;
    Randomizer newColor = new Randomizer();
    
    private void Start()
    {
        var randomColor = newColor.ChangeColor();
        SetColor(randomColor);
    }
    public void OnDrag(PointerEventData eventData)
    {
        var direction =  ToWorldSpace(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.y - offset));
        Move(direction);
    }
    private Vector3 ToWorldSpace(Vector3 screenSpace) => Camera.main.ScreenToWorldPoint(screenSpace);
}
