using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour
{
    
    public float dragSpeed = 1f;
    Vector3 lastMousePos;
    
    void OnMouseDown() {
        lastMousePos = Input.mousePosition;
    }
    
    void OnMouseDrag() {
        Vector3 delta = Input.mousePosition - lastMousePos;
        Vector3 pos = transform.position;
        pos.x += delta.x/128 * dragSpeed;
        transform.position = pos;
        lastMousePos = Input.mousePosition;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
