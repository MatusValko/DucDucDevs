using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpikeLever : MonoBehaviour
{
    [SerializeField] private List<GameObject> allSpikes;
    [SerializeField] private List<GameObject> allLevers;
    [SerializeField] private Sprite secondState;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] public GameObject spike;
    [SerializeField] public Sprite spikeDown;
    
    
    [SerializeField] private GameObject firstLeverOpaque;
    [SerializeField] private GameObject secondLeverOpaque;
    [SerializeField] private GameObject thirdLeverOpaque;
    // Start is called before the first frame update
    void Start()
    {
        //SetupLevers();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnMouseDown(){
        Debug.Log("SPIKE DOWN");
        _spriteRenderer.sprite = secondState;
        if (gameObject.name == "Lever (1)")
        {
            //Debug.Log("Lever (1)");
            firstLeverOpaque.SetActive(true);
            //var transformPosition = gameObject.transform.position;
            //transformPosition.x = 0.1412f;
            //transform.position = transformPosition;
        }
        else if (gameObject.name == "Lever (2)")
        {
            //Debug.Log("Lever (2)");
            secondLeverOpaque.SetActive(true);
            //var transformPosition = gameObject.transform.position;
            //transformPosition.x = -0.2377f;
            //transform.position = transformPosition;
        }
        else if (gameObject.name == "Lever (3)")
        {
            //Debug.Log("Lever (3)");
            thirdLeverOpaque.SetActive(true);
            
            //var transformPosition = gameObject.transform.position;
            //transformPosition.x = -0.1861f;
            //transform.position = transformPosition;
        }

        spike.GetComponent<SpriteRenderer>().sprite = spikeDown;
        spike.GetComponent<BoxCollider2D>().enabled = false;
        gameObject.SetActive(false);
    }
    private void pushLever()
    {
        
    }
    
    
}
