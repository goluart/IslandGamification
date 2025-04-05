using UnityEngine;

public class doorcontrolcode1 : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        // Search the door and open if player
        if (other.name.Equals("player"))
        {
            GameObject.Find("door1").GetComponent<Animator>().SetInteger("doorstate1", 1);
        } // if
    } // OnTriggerEnter

    private void OnTriggerExit(Collider other)
    {
        // Search the door and close if player
        if (other.name.Equals("player"))
        {
            GameObject.Find("door1").GetComponent<Animator>().SetInteger("doorstate1", 0);
        } // if
    } // OnTriggerExit
} // class
