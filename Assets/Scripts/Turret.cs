using UnityEngine;
using UnityEngine.InputSystem;

public class Turret : MonoBehaviour
{

    private void Update()
    {

        
        // Get the mouse position in world space
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        // Calculate the direction from the object to the mouse
        Vector3 direction = mousePos - transform.position;
        direction.z = 0f; // ensure we're only working in 2D

        // Calculate the angle in degrees
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Apply the rotation
        transform.rotation = Quaternion.Euler(0f, 0f, angle - 90f);

    }
}
