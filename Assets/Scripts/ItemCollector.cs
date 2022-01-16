using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemCollector : MonoBehaviour
{
    int vaccine = 0;

    [SerializeField] Text vaccineText;


    private void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Vaccine")) 
        {
            vaccine++;
            vaccineText.text = "Points: " + vaccine;
            Destroy(other.gameObject);
        }
    }
}
