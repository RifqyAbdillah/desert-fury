using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private float targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (targetPosition == 5f)
            {
                targetPosition = 0f;
            }
            else if (targetPosition == 0f)
            {
                targetPosition = -5f;
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (targetPosition == -5f)
            {
                targetPosition = 0f;
            }
            else if (targetPosition == 0f)
            {
                targetPosition = 5f;
            }
        }
        MoveToTargetPosition();
    }
    
    void MoveToTargetPosition()
    {
        Vector3 targetPos = new Vector3(targetPosition, transform.position.y, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }
}