using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusCollision : MonoBehaviour
{
   
    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Player")
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene());
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
