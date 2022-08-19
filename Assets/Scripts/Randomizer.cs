using UnityEngine;

public class Randomizer 
{
    public Color ChangeColor() =>  Random.ColorHSV();
    

    public Vector3 RandomPosition(Vector3 size)
    {
        var posX = Random.Range(-size.x, size.x);
        var posZ = Random.Range(-size.z, size.z);

        return new Vector3(posX, size.y, posZ);
    }
}

