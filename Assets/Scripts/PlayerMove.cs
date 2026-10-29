using System;
using UnityEngine;


[RequireComponent(typeof(Renderer))]
public class PlayerMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float speed = 1.0f;
    [SerializeField] private Renderer rend;
    [SerializeField] private Color color = Color.red;
    void Start()
    {
        rend = GetComponent<Renderer>();
        color = GetComponent<Color>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Time.deltaTime * speed * Vector3.right);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            // Delta Time detach controller from Framerate
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    
    }

    void OnMouseDown()
    {
        Debug.Log("Mouse Down");
        rend.material.color = UnityEngine.Random.ColorHSV();
    }
}
