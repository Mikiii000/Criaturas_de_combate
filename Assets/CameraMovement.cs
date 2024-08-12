using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform playerPosition;
    public Vector3 cameraDelta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(
                playerPosition.position.x + cameraDelta.x, 
                playerPosition.position.y + cameraDelta.y, 
                playerPosition.position.z + cameraDelta.z
            );
    }
}
