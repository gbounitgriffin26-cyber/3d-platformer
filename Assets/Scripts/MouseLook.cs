using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] float mouseSensitivity = 2f;
    [SerializeField] Transform playerCamera;

    float xRotation = 0f;
    
    float movementSpeed = 6f;
    Rigidbody rb;
    public float minPitch = -30f;
    public float maxPitch = 60f;
    private void Start()
    {
      
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        transform.Rotate(Vector3.up * mouseX);

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        

        

    }

    void LateUpdate()
    {
        playerCamera.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

    }
}
