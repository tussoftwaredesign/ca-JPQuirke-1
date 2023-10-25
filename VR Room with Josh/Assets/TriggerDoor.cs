using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour
{
    [SerializeField] private Animator FrontMainDoor = null;
    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("player"))
        {
            if (openTrigger)
            {
                FrontMainDoor.Play("DoorOpen", 0, 0.0f);
                gameObject.SetActive(false);    
            }
            else if (closeTrigger)
            {
                FrontMainDoor.Play("DoorClose", 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
    }

}
