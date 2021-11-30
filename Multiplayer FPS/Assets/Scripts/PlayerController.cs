using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /// <summary>
    /// Camera
    /// </summary>
    public Transform viewPoint;

    public float mouseSensitivity = 1f;
    private float verticalRotationStore;
    private Vector2 mouseInput;
   
    void Start()
    {
        
    }

    
    void Update()
    {
        mouseInput = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y") * mouseSensitivity);
        
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y 
                                                                + mouseInput.x, transform.rotation.eulerAngles.z);
    }
}
