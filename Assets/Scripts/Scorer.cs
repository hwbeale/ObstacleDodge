using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("You have bumped into a thing this many times: " + hits);
        }
    }
}
