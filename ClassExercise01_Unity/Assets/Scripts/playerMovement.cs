using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Debug.Log("Player movement script started.");
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = Input.GetAxis("Horizontal"); // Get horizontal input
        float ySpeed = Input.GetAxis("Vertical"); // Get vertical input

        Vector3 Movement = new Vector3(xSpeed, ySpeed, 0f); // Create a movement vector
        transform.Translate(Movement * speed * Time.deltaTime); // Move the player based on input and speed

    }
}
