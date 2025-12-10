using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float speed;
    Vector3 playerPosition;

    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
        ProjectileMovement();
        DestroyWhenReached();
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }

    }

    void ProjectileMovement()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed);
    }
}
