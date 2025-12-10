using UnityEngine;

public class Mover : MonoBehaviour
{[SerializeField] float MoveSpeed = 10f;
     void Start()
    {
        PrintInstrucions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }


    void PrintInstrucions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Press W,A,S,D to Move");
        Debug.Log("Dont bump int othings");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * MoveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
}