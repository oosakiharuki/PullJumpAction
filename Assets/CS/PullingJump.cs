using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullingJump : MonoBehaviour
{

    private Rigidbody rb;   
    private Vector3 clickPosition;
    [SerializeField]
    private float jumpPower = 10;
    private bool isCanJump;



    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("押した瞬間");
    }

    private void OnCollisionStay(Collision collision)
    {
        //Debug.Log("触っている");

        ContactPoint[] contacts = collision.contacts;

        Vector3 otherNomal = contacts[0].normal;

        Vector3 upVector = new Vector3(0, 1, 0);

        float dotUN = Vector3.Dot(upVector, otherNomal);

        float dotDec = Mathf.Acos(dotUN) * Mathf.Rad2Deg;

        if (dotDec <= 45)
        {
            isCanJump = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        //Debug.Log("空中にいる");
        isCanJump = false;
    }



    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        // rb = GetComp はしょうりゃく
    }
   
    


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickPosition = Input.mousePosition;
        }
        if (isCanJump)
        {
            if (Input.GetMouseButtonUp(0))
            {
                Vector3 dist = clickPosition - Input.mousePosition;

                if (dist.sqrMagnitude == 0)
                {
                    return;
                }
                rb.velocity = dist.normalized * jumpPower;
            }
        }
    }
}
