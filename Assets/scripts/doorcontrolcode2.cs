using UnityEngine;

public class doorcontrolcode2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Search the door and open if player
        if (other.name.Equals("player"))
        {
            GameObject.Find("door2_right").GetComponent<Animator>().SetInteger("doorstate2", 1);
            GameObject.Find("door2_left").GetComponent<Animator>().SetInteger("doorstate2", 1);
        } // if
    } // OnTriggerEnter

    private void OnTriggerExit(Collider other)
    {
        // Search the door and close if player
        if (other.name.Equals("player"))
        {
            GameObject.Find("door2_right").GetComponent<Animator>().SetInteger("doorstate2", 0);
            GameObject.Find("door2_left").GetComponent<Animator>().SetInteger("doorstate2", 0);
        } // if
    } // OnTriggerExit
} // class
