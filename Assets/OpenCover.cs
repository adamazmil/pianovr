using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCover : MonoBehaviour
{
    //public Animator animator; 
    // Start is called before the first frame update
    void Start()
    {
    //animator= GetComponent<Animator>();
    //animation=GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        
                if (GetComponent<Animation>()!=null){
                    Debug.Log("playing");
                    GetComponent<Animation>().Play("openCover");
        }

    }

}
