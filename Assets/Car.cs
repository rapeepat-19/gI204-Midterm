using UnityEngine;

public class Car : MonoBehaviour
{
    public float laneWidth = 3.5f;  
    public float moveSpeed = 10f;   
    private Rigidbody rb;
    private Vector3 targetPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody>();  
        targetPosition = rb.position;  
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            targetPosition.x += laneWidth;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            targetPosition.x -= laneWidth; 
        }
    }

    void FixedUpdate()
    {
       
        rb.MovePosition(Vector3.Lerp(rb.position, targetPosition, Time.fixedDeltaTime * moveSpeed));
    }
}


        
    

