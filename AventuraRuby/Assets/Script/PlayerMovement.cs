using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    void Start()
    {
        
    }

   
    void Update()
    {

        float horizontal = Input.GetAxis ("horizontal");
        float vertical = Input.GetAxis("vertical");
        Vector2 position = transform.position;
        position.x = position.x + 0.1f * horizontal;
        position.y = position.y + 0.1f * vertical;
        transform.position = position;

    }
}
