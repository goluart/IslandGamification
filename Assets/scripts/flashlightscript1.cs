using UnityEngine;

public class flashlightscript1 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.GetComponent<Light>().enabled = true;
        } // if

        if (Input.GetMouseButtonUp(0))
        {
            this.GetComponent<Light>().enabled = false;
        } // if
    }  // Update
}  // class

