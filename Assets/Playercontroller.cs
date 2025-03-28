using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public float speed = 10f;
    public float laneDistance = 2f; 

    private Vector3 targetPosition;

    void Start()
    {
        targetPosition = transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -laneDistance)
        {
            targetPosition = new Vector3(-laneDistance, transform.position.y, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < laneDistance)
        {
            targetPosition = new Vector3(laneDistance, transform.position.y, transform.position.z);
        }

        
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speed);
    }
}

        
    

