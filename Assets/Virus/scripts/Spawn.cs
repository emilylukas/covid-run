using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
	public Transform spawnPos;
	public GameObject virus; 

	
    // Set your offset here (in seconds)
    float timeoutDuration = 3;

    float timeout = 3;

    void Update()
    {
        if (timeout > 0)
        {
            // Reduces the timeout by the time passed since the last frame
            timeout -= Time.deltaTime;

            // return to not execute any code after that
            return;
        }

        // this is reached when timeout gets <= 0

        // Spawn object once
        Instantiate(virus, spawnPos.position, spawnPos.rotation);

        // Reset timer
        timeout = timeoutDuration;
    }

}
