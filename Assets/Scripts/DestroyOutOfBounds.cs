using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{  

    private float bound = -25;
    private float botBound = -10;

    void Update()
    {
        
        if (transform.position.z < bound) {
        
            Destroy(gameObject);

        }
        
        if (transform.position.y < botBound) {
       
            Destroy(gameObject);
            Debug.Log("Game Over!");
        
        }
    }
}
