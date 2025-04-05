using UnityEngine;

public class quitcode : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        // Stop the application with ESC-button
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    } // Update
} // class
