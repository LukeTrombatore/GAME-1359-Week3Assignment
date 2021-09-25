using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    [SerializeField]
    string text = "";
    // Start is called before the first frame update
    void Start()
    {

    }

    //called first and always enabled
    private void Awake()
    {
        Debug.Log("HelloWorld");
    }

    // Update is called once per frame
    void Update()
    {

    }
    //good for physics
    private void FixedUpdate()
    {
        
    }
}