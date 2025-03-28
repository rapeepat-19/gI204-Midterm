using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float laneOffset = 3f; // ระยะห่างแต่ละเลน
    public float moveSpeed = 10f; // ความเร็วในการเลื่อนเลน

    private int currentLane = 0; // 0 = กลาง, -1 = ซ้าย, 1 = ขวา
    private Vector3 targetPosition;

    void Start()
    {
        targetPosition = transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            if (currentLane > -1)
            {
                currentLane--;
                UpdateTargetPosition();
            }
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            if (currentLane < 1)
            {
                currentLane++;
                UpdateTargetPosition();
            }
        }

       
        transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);
    }

    void UpdateTargetPosition()
    {
        targetPosition = new Vector3(currentLane * laneOffset, transform.position.y, transform.position.z);
    }
}


