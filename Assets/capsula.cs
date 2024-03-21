using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsula : MonoBehaviour
{

    public float speed = 1;
    public static float deltaTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += Time.deltaTime * Vector3.forward * speed;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
             transform.position += Time.deltaTime * Vector3.back * speed;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += Time.deltaTime * Vector3.left * speed;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += Time.deltaTime * Vector3.right * speed;
        }
    }
}
