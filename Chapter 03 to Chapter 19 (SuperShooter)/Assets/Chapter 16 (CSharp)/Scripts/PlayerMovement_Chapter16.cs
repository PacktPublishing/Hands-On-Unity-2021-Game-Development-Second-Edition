using UnityEngine;

public class PlayerMovement_Chapter16 : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

    private Rigidbody rb;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) 
            rb.AddRelativeForce(0, 0, speed * Time.deltaTime);
        
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            rb.AddRelativeForce(0, 0, -speed * Time.deltaTime);
        
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            rb.AddRelativeForce(-speed * Time.deltaTime, 0, 0);
        
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            rb.AddRelativeForce(speed * Time.deltaTime, 0, 0);

        float mouseX = Input.GetAxis("Mouse X");
        rb.AddRelativeTorque(0, mouseX * rotationSpeed * Time.deltaTime, 0);
    }
}

