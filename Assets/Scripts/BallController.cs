using UnityEngine;
using UnityEngine.EventSystems;

public class BallController : Figures, IDragHandler
{
    private Material ballMaterial;

    private void Awake()
    {
        ballMaterial = GetComponent<MeshRenderer>().material;
    }
    private void Start()
    {
            SetColor(ballMaterial);
    }
    public void OnDrag(PointerEventData eventData)
    {
        Move();
    }


}
