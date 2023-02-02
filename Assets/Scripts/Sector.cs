using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sector : MonoBehaviour
{
    
    [SerializeField] private BoxCollider2D damageCollider;
    [SerializeField] private BoxCollider2D playerCollider;
    [SerializeField] private Player player;

    // Start is called before the first frame update

    private void Awake()
    {
        player = FindObjectOfType<Player>();
        //playerCollider = player.GetComponent<BoxCollider2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.PAUSED)
        {
            var transformPosition = transform.position;
            transformPosition.y = transformPosition.y - GameManager.GAME_SPEED;
            transform.position = transformPosition;
        }
        
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("COLLIDER" + col );
        if (col.gameObject.name == "Player")
        {
            player.Die();
        }
        
    }
   
}
