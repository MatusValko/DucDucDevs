using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawLever : MonoBehaviour
{
    
    [SerializeField] private Sprite secondState;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Saw saw;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnMouseDown(){
        Debug.Log("STOP SAW");

        _spriteRenderer.sprite = secondState;
        var transformPosition = gameObject.transform.position;
        transformPosition.x = 3.64f;
        transform.position = transformPosition;
        saw.ismoving = false;
    }
    
    
}
