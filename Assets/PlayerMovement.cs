using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public InputActionAsset actions;
    private Vector2 move;
    [Range(1, 50)]
    public int speed = 1;

    void Start() // Start is called before the first frame update
    {
        
    }
    void Update() // Update is called once per frame
    {
        gameObject.transform.position += new Vector3(move.x, 0, move.y) * speed * Time.deltaTime;
    }

    public void onMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }
}
