using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    Vector3 playerposition;

    void Start()
    {
        playerposition = GameObject.FindWithTag("Player").transform.position;
    }

    void Update()
    {
        playerposition = GameObject.FindWithTag("Player").transform.position;
        transform.position = Vector3.MoveTowards(transform.position, playerposition, Time.deltaTime * speed);
    }
}
