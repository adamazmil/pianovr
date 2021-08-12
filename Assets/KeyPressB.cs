using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class KeyPressB : MonoBehaviour
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
    //public AudioSource playSound;
    
     public AudioClip clip;
    private void OnTriggerEnter(Collider other){
        
                if (GetComponent<Animation>()!=null){
                    Debug.Log("playing");
                    GetComponent<Animation>().Play("KeyPressB");
                    AudioSource.PlayClipAtPoint(clip, new Vector3(-0.7f,3.4f,1.1f));
        }

    }

}
