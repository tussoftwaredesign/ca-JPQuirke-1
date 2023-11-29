using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class EndGame : MonoBehaviour
{
    public GameObject winUI;

    public int requiredObjects = 7; // Number of cups required for key activation.


    private int ObjectsInTruck = 0;


    public void Start()
    {
        winUI.SetActive(false);


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Object")) // Assuming the cups have a "Cup" tag.
        {
            ObjectsInTruck++;
            Debug.Log("Object entered the sink. Total cups in sink: " + ObjectsInTruck);

            if (ObjectsInTruck >= requiredObjects)
            {
                winUI.SetActive(true);

            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Object"))
        {
            ObjectsInTruck--;
            Debug.Log("Object exited the sink. Total cups in sink: " + ObjectsInTruck);

            if (ObjectsInTruck < requiredObjects)
            {
                winUI.SetActive(false);

            }
        }
    }
}