using UnityEngine;

public abstract class Figures : MonoBehaviour
{
    private int offset = 2;
    Randomizer newColor = new Randomizer();
    protected virtual void Move()
    {
        transform.position = ToWorldSpace(new Vector3(Input.mousePosition.x, Input.mousePosition.y,Camera.main.transform.position.y-offset));
    }
   
    private Vector3 ToWorldSpace(Vector3 screenSpace) => Camera.main.ScreenToWorldPoint(screenSpace);

    protected virtual void SetColor(Material ballMaterial)
    {
        newColor.ChangeColor(ballMaterial);
    }
    
}
