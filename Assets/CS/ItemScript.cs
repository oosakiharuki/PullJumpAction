using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    GameObject ItemPrefub;

    private Animator aimator;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter");
    }


    private void OnTriggerStay(Collider other)
    {
        //DestroySelf();
        aimator.SetTrigger("Get");
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
        aimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
