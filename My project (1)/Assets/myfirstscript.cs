using UnityEngine;

public class myfirstscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

        
    {
        // s = ut s - distance = u * (velocity) * t (time)
        
        if (Input.GetKey(KeyCode.UpArrow))

        {

            transform.position += Vector3.up * Time.deltaTime;

        } 
        
        if(Input.GetKey(KeyCode.DownArrow))

        {

            transform.position += Vector3.down * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))

        {

            transform.position += Vector3.left * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))

        {

            transform.position += Vector3.right * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.Space))

        {
            transform.position += Vector3.forward * Time.deltaTime;
        }
    }
}