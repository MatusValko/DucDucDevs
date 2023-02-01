using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    [SerializeField] private BoxCollider2D playerCollider;
    
    private Rigidbody2D body;
    [SerializeField] private float movementSpeed;
    
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    private void FixedUpdate()
    {
        //MovePlayer();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }


    public void Die()
    {
        //Time.timeScale = 0;
        Debug.Log("DEAD DUCKKK!");
    }
    
    private void MovePlayer()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");
       
        body.velocity = new Vector2(inputX * movementSpeed, inputY * movementSpeed);
    }
    
}
