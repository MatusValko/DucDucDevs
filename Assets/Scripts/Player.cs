using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    
    [SerializeField] private BoxCollider2D playerCollider;
    
    public Rigidbody2D body;
    private Collider2D colider;
    [SerializeField] private float movementSpeed;
    [SerializeField] private GameObject gameover;

    public AudioSource Source;
    public AudioClip Clip;
    
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Source.clip = Clip;
        Source.loop = true;
        Source.Play();
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
        Debug.Log("DEAD DUCKKK!");
        //Time.timeScale = 0;
        
        gameover.SetActive(true);
        
    }


    public void LoadScene()
    {
        Debug.Log("SOM TU");
        SceneManager.LoadScene("SampleScene");
    }

    
}
