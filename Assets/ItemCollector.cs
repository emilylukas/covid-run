using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    int vaccine = 0;
    private void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Vaccine")) 
        {
            Destroy(other.gameObject);
            vaccine++;
            Debug.Log("Vaccine points: " + vaccine);
        }
    }
}
