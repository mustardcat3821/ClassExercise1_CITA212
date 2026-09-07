using Unity.VisualScripting;
using UnityEngine;

public class plrMovementUpd : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float rotateSpeed = 120f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }
    // Rotation

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0f, 0f, rotateSpeed * Time.deltaTime); // Rotate clockwise
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0f, 0f, -rotateSpeed * Time.deltaTime); // Rotate counterclockwise
        }

        float xSpeed = Input.GetAxis("Horizontal"); // Get horizontal input
        float ySpeed = Input.GetAxis("Vertical");   // Get vertical input

        Vector3 Movement = new Vector3(xSpeed, ySpeed, 0f); // Create a movement vector
        transform.Translate(Movement * speed * Time.deltaTime); // Move the player based on input and speed
    }
}
