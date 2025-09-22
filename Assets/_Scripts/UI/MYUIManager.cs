using UnityEngine;

public class MYUIManager : MonoBehaviour
{
    public GameObject instructionPanel; // Holds instruction text + Play button
    public GameObject gameplayRoot;     // Root object to activate gameplay

    public void StartGame()
    {
        instructionPanel.SetActive(false);
        gameplayRoot.SetActive(true);

        // Lock and hide the cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}