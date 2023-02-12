using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    
    public GameObject player;
    private Vector3 offset = new Vector3(0, 2, -4);

    void LateUpdate()
    {
        
        if (player != null){
        
            transform.position = player.transform.position + offset;
        
        }

    }
}
