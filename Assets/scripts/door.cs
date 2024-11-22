using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    [SerializeField] private Animator Mydoor = null;

    [SerializeField] private bool Dooropen = false;
    
    public bool doortrigger;

    private void onTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(doortrigger = true)
            {
                Mydoor.Play("Dooropen",0,0.0f);
                gameObject.SetActive(false);
            }
        }
    }
}
