using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;   
        }
    }

    void OnCollisionExit(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.grey; 
        gameObject.tag = "Hit";
    }
}
