using UnityEngine;

public class CursorControl : MonoBehaviour
{
    void Start()
    {
        // Hide the cursor
        Cursor.visible = false;
        // Lock the cursor to the center of the screen
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Optional: Allow unlocking the cursor with a key press (e.g., Escape)
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Cursor.lockState == CursorLockMode.Locked)
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }
}