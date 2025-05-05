using UnityEngine;

public class Player : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Player script is running!");
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
            Debug.Log("Holding Space");
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jump");
        }
    }
}