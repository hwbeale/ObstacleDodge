using UnityEngine;

public class Dropper : MonoBehaviour
{

    [SerializeField] float TimeToWait = 3f;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
        myMeshRenderer = GetComponent<MeshRenderer>();
         
        myMeshRenderer.enabled = false;
        myRigidBody.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > TimeToWait)
        {
            myMeshRenderer.enabled = true;
            myRigidBody.useGravity = true;
        }
    }
}
