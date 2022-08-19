using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] Transform spawner;
    private Transform target;
    private Color color;
    BallController ball;
   
    private void Start()
    {
        color = Color.red;
        target = spawner.GetChild(1);
        ball = target.GetComponent<BallController>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetNewColor();
        }
        SetNewMove();
    }

    private void SetNewColor()
    {
        ball.SetColor(color);
    }
    private void SetNewMove()
    { 
        var directionPosX = Input.GetAxisRaw("Horizontal");
        var direction = new Vector3(directionPosX, target.position.y);
        ball.Move(direction);
    }




}
