using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset = new Vector3(0, 0, -20);  // Adjust the offset if needed

    void LateUpdate() {
        // Update position to follow player with the desired offset
        transform.position = player.position + offset;
        
        // Keep the camera rotation as set in the Inspector
    }
}