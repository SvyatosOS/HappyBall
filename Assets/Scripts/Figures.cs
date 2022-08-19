using UnityEngine;

public abstract class Figures : MonoBehaviour
{
    private Material targetMaterial;
     
    private void Awake()
    {
        targetMaterial = GetComponent<MeshRenderer>().material;
    }
    public virtual void Move(Vector3 direction)
    {
        transform.position = direction;
    }
   
    public virtual void SetColor(Color color)
    {
            targetMaterial.color = color;
    }
    
}
