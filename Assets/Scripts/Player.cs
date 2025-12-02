using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public string player = "player";
    [SerializeField] float moveSpeed;
    [SerializeField] bool isEnabled;
    [SerializeField] Rigidbody2D rb;

    public void SetMoveSpeed(float speed)
    {
        moveSpeed = 5f;
    }

    public void SetInvulnerability(bool isEnabled)
    {
        isEnabled = false;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (isInvulnerable)
        {

        }
    }

    public void Move()
    {
        if (rb != null)
        {
        }

    }

    public void Jump(float time)
    {
        if (rb != null)
        {

        }
    }
}
