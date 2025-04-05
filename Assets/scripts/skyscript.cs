using UnityEngine;

public class skyscript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Rotate the skybox
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * 0.5f);
    } // Update
} // class
