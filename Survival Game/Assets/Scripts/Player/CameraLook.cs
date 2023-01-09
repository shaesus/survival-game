using UnityEngine;

public class CameraLook : MonoBehaviour
{
    [SerializeField] private float sensitivity = 5f;
    
    private Transform _playerBody;
    
    private float _mouseX;
    private float _mouseY;

    private float _xRotation = 0f;

    private void Awake()
    {
        _playerBody = transform.parent;
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        _mouseX = Input.GetAxis("Mouse X") * sensitivity * 100 *  Time.deltaTime;
        _mouseY = Input.GetAxis("Mouse Y") * sensitivity * 100 * Time.deltaTime;

        _xRotation -= _mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -90, 90);
        
        transform.localRotation = Quaternion.Euler(_xRotation, 0, 0);
        _playerBody.Rotate(Vector3.up * _mouseX);
    }
}
