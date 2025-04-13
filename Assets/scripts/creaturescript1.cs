using UnityEngine;

// Tarvitaan navigointia varten
using UnityEngine.AI;

public class creaturescript1 : MonoBehaviour
{
    // T�h�n voidaan raahata navigoinnin kohde Inspector-ikkunassa
    public GameObject kohde1 = null;

    void Start()
    {
        
    } // Start

    void Update()
    {
        // Navigointi t�nne, koska kohde liikkuu
        this.GetComponent<NavMeshAgent>().SetDestination(this.kohde1.GetComponent<Transform>().position);
    } // Update

    private void OnTriggerEnter(Collider other)
    {
        // Uhitellaan vain pelaajalle
        if (other.name.Equals("player"))
        {
            this.GetComponent<Animator>().SetInteger("creaturestate1", 1);
        } // if
    } // OnTriggerEnter

    private void OnTriggerExit(Collider other)
    {
        // Palataan k�velyyn, kun pelaaja poistuu alueelta
        if (other.name.Equals("player"))
        {
            this.GetComponent<Animator>().SetInteger("creaturestate1", 0);
        } // if
    } // OnTriggerExit
} // class
