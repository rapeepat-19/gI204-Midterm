using UnityEngine;

public class MovingRoad : MonoBehaviour
{
    public float speed = 60f;
    public Vector3 moveDirection = new Vector3(0, 0, -1);  

    void Update()
    {
        transform.position += Vector3.left * -60 * speed * Time.deltaTime;
    }
}

