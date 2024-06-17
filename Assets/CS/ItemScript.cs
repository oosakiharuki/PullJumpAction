using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IremScript : MonoBehaviour
{
    GameObject ItemPrefub;

    private Animator aimator;

    private AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter");
        audioSource.Play();
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
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
