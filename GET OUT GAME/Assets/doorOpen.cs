using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class OpenDoor : MonoBehaviour
{

    public GameObject door;

    public GameObject attachKey;

    Animator Exterior_Door;

    
    bool locked = false;
    // Start is called before the first frame update
    void Start()
    {
        door.SetActive(true);
        Exterior_Door = door.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (locked == false)
        {
             if (attachKey.activeSelf) 
          {
                 StartCoroutine(doorCoolDown(1f));
                locked = true;
           }
           else
           {
             door.SetActive(true);
           }
        }
       

    }

    IEnumerator doorCoolDown(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        Exterior_Door.SetTrigger("CloseDoor");
    }


}

