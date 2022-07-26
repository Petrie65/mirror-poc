using Mirror;
using UnityEngine;

public class Player : NetworkBehaviour
{
    void Update()
    {
        HandleMovement();
    }
    
    void HandleMovement() {
        if (isLocalPlayer) {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);
            transform.position = transform.position + movement;
        }
    }
}
