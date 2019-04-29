using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceController : MonoBehaviour
{
    Animator animator;
    bool isDance1 = false;
    bool isDance2 = false;
    bool isDance3 = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    /*

    void OnColliionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            if (!isDance1)
            {
                animator.SetBool("dance1", true);
                isDance1 = !isDance1;
                Debug.Log("isDance1 " + isDance1);
            }
            else
            {
                animator.SetBool("dance1", false);
                isDance1 = !isDance1;
                Debug.Log("isDance1 " + isDance1);
            }
        }
    }
    */

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Q key was pressed.");

            if (!isDance1)
            {
                animator.SetBool("dance1", true);
                isDance1 = !isDance1;
                Debug.Log("isDance1 " + isDance1);
            }
            else
            {
                animator.SetBool("dance1", false);
                isDance1 = !isDance1;
                Debug.Log("isDance1 " + isDance1);
            }


        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W was pressed.");


            if (!isDance2)
            {
                animator.SetBool("dance2", true);
                isDance2 = !isDance2;
                Debug.Log("isDance2 " + isDance2);
            }
            else
            {
                animator.SetBool("dance2", false);
                isDance2 = !isDance2;
                Debug.Log("isDance2 " + isDance2);
            }

        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E key was pressed.");


            if (!isDance3)
            {
                animator.SetBool("dance3", true);
                isDance3 = !isDance3;
                Debug.Log("isDance3 " + isDance3);
            }
            else
            {
                animator.SetBool("dance3", false);
                isDance3 = !isDance3;
                Debug.Log("isDance3 " + isDance3);
            }

        }
    }
}
