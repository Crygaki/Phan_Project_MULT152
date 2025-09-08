using UnityEngine;

public class EnemyFollowsPlayer : MonoBehaviour
{
    public Transform player;      // Assign the player's transform in the Inspector
    public float speed = 3f;      // Movement speed
    public float followRange = 10f; // Distance within which enemy starts following

    void Update()
    {
        if (player == null) return;

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance < followRange)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;

            // Optional: rotate to face the player
            transform.LookAt(player);
        }
    }
}
