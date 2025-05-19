using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello");
        Debug.Log("I am bidhan");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, 5f);
    }
}
