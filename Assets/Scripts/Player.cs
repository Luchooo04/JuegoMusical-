using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 100f;

    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

       
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;

       
        transform.Rotate(Vector3.up, mouseX);

        
        float newRotationX = mainCamera.transform.localEulerAngles.x - mouseY;
        //newRotationX = Mathf.Clamp(newRotationX, -90f, 90f);
        mainCamera.transform.localEulerAngles = new Vector3(newRotationX, 0f, 0f);



        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
