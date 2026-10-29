using UnityEngine;

public class HelloWorld : MonoBehaviour
{

    public GameObject iniObject;
    void Awake()
    {
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(iniObject,Vector3.one, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
