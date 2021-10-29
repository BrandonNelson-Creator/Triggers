using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Sam Robichaud NSCC

public class TriggerSetActive : MonoBehaviour
{
    public GameObject redLight;
    public GameObject greenLight;
    
    void OnTriggerEnter(Collider other)
    {
        redLight.SetActive(false);
        greenLight.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        redLight.SetActive(true);
        greenLight.SetActive(false);
    }       
}
