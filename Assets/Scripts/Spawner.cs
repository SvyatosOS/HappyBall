using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Vector3 sizeGround;
    [SerializeField] private GameObject ballPrefabs;
    [SerializeField] private int countBall;
    Randomizer randomizer = new Randomizer();

    private void Awake()
    {
        Spawn();
    }
    [ContextMenu("Spawn")]
    private void Spawn()
    {
        for (int i = 0; i < countBall; i++)
        {
            var position = randomizer.RandomPosition(sizeGround);
            
            Instantiate(ballPrefabs,position,Quaternion.identity,this.transform);
         
        }
       
    }
}
