using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeLever : MonoBehaviour
{
    [SerializeField] private List<GameObject> allSpikes;
    [SerializeField] private Sprite secondState;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnMouseDown(){
        
        
        _spriteRenderer.sprite = secondState;
        var transformPosition = gameObject.transform.position;
        transformPosition.x = 3.64f;
        transform.position = transformPosition;
        
        
    }
}
