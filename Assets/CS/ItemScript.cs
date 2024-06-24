using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IremScript : MonoBehaviour
{
    GameObject ItemPrefub;

    private Animator aimator;

    private AudioSource audioSource;

    private bool Claer;

    public GameObject clearText;
    public GameObject clearText2;

    public GameObject NectStage;

    public bool IsCleard()
    {
        if (Claer == true)
        {
            return true;
        }
        return false;
    }



    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter");
        audioSource.Play();
        Claer = true;
    }


    private void OnTriggerStay(Collider other)
    {
        //DestroySelf();
        aimator.SetTrigger("Get");

    }
    private void DestroySelf()
    {
        NectStage.GetComponent<GameManagerStrict>().v = true;
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
        Claer = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsCleard())
        {
            clearText.SetActive(true);
            clearText2.SetActive(true);
        }
    }
}
