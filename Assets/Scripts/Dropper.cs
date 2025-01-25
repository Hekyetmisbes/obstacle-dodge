using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;

    MeshRenderer myrenderer;

    Rigidbody myrigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myrenderer = GetComponent<MeshRenderer>();
        myrenderer.enabled = false;
        myrigidbody = GetComponent<Rigidbody>();
        myrigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait)
        {
            myrenderer.enabled = true;
            myrigidbody.useGravity = true;
        }
    }
}
