using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 100f;


    private Camera mainCamera;

    public AudioSource pasos;
    private bool hActivo;
    private bool vActivo;
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

        if (Input.GetButtonDown("Horizontal")) 
        {
            if (vActivo == false)
            {
                hActivo = true;
                pasos.Play();
            }
            
        }
        if (Input.GetButtonDown("Vertical"))
        {
            if (hActivo == false)
            {
                vActivo = true;
                pasos.Play();
            }
        }

        if (Input.GetButtonUp("Horizontal")) 
        {
            hActivo = false;

            if (vActivo == false)
            {
                pasos.Pause();
            }
        }
        if (Input.GetButtonUp("Vertical"))
        {
            vActivo = false;

            if (hActivo == false)
            {
                pasos.Pause();
            }
        }


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
