
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketCheck : MonoBehaviour
{
    public GameObject SocketAttach;
    // Start is called before the first frame update
    void Start()
    {
        SocketAttach.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.name == "Key" && gameObject.name == "KeySocket")
        {
            SocketAttach.SetActive(true);

            Debug.Log("Hello");

        }
        else
        {
            Debug.Log("Wrong Obj");

        }
    }
    public void OnTriggerExit(Collider obj)
    {
        SocketAttach.SetActive(false);
    }
}

