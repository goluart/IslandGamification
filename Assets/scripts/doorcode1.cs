using UnityEngine;

public class doorcode1 : MonoBehaviour
{
    void Start()
    {
        
    } // Start

    void Update()
    {
        // F-n�pp�in aukaisee oven
        if (Input.GetKeyDown(KeyCode.F))
        {
            this.GetComponent<Animator>().SetInteger("doorstate1", 1);
        } // if

        // K-n�pp�in sulkee oven
        if (Input.GetKeyDown(KeyCode.K))
        {
            this.GetComponent<Animator>().SetInteger("doorstate1", 0);
        } // if
    } // Update
} // class
