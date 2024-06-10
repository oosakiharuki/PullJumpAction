using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    GameObject ItemPrefub;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter");
    }


    private void OnTriggerStay(Collider other)
    {
        DestroySelf();
    }
    private void DestroySelf()
    {
        Destroy(gameObject);
    }


    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit");
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
