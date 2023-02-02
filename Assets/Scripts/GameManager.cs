using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class GameManager : MonoBehaviour
{
    [SerializeField] private Button lever;
    [SerializeField] private GameObject leverGoGameObject;
    //[SerializeField] private Camera camera;
    public static bool PAUSED = true;
    [SerializeField] public static float GAME_SPEED = 0.03f;
    // Start is called before the first frame update
    private void Awake()
    {
        
    }

    void Start()
    {
        //StartMenu();
        //lever.onClick.AddListener(StartGame);
    }

    // Update is called once per frame
    void Update()
    {
        //OnMouseDown();
        
        
        /*
        if (Input.GetMouseButtonDown(0)){ // if left button pressed...
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit leverGoGameObject;
            if (Physics.Raycast(ray, out leverGoGameObject))
            {
                StartGame();
            }
        }*/
    }
    
    public void StartMenu()
    {
        //Time.timeScale = 0;
        PAUSED = true;
    }
    
    public void StartGame()
    {
        Debug.Log("START GAME");
        PAUSED = false;
        Time.timeScale = 1;
    }
    
    
    void OnMouseDown(){
        Debug.Log("START GAME");
        PAUSED = false;
        Time.timeScale = 1;
    }
}
