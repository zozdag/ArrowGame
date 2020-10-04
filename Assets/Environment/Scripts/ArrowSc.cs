using System.Collections;
using System.Collections.Generic;
using UnityEditor.Profiling.Memory.Experimental;
using UnityEngine;

public class ArrowSc : MonoBehaviour
{
    private BoxCollider ArrowboxCollider;
    private Rigidbody Arrowrigidbody;
    RaycastHit temas;
    string isim;
    void Start()
    {
        ArrowboxCollider = GetComponent<BoxCollider>();
        Arrowrigidbody = GetComponent<Rigidbody>();
        
    }

    
    void Update()
    {
       
        if(Physics.Raycast(transform.position,transform.forward,out temas, 4.2f))
        {
            isim = temas.collider.gameObject.name;

            if(isim == "TargetRed")
            {
                manager.Puan += 10;
            }
            if(isim == "TargetGreen")
            {
                manager.Puan += 4;
            }
            if (isim == "TargetBlack")
            {
                manager.Puan += 2;
            }
            Debug.Log(manager.Puan);
           
                RemoveObjComponents();
           
       

        }
    }

   

    private void RemoveObjComponents()
    {
        Destroy(Arrowrigidbody) ;
        Destroy(ArrowboxCollider);
        Destroy(this);
    }
}

