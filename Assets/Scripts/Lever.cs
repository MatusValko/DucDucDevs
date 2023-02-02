using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField] private GameObject Cage;
    [SerializeField] private Sprite secondState;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (cageup && GameManager.PAUSED )
        {
            var transformPosition = Cage.transform.position;
            transformPosition.y = transformPosition.y + 0.05f;
            Cage.transform.position = transformPosition;
            //Debug.Log(Cage.transform.position.y);
            if (Cage.transform.position.y > 2)
            {
                cageup = false;
                Debug.Log("START GAME");
                GameManager.PAUSED = false;
                Cage.SetActive(false);
            }
        }
        if (!cageup && !GameManager.PAUSED )
        {
            var transformPosition = transform.position;
            transformPosition.y = transformPosition.y - GameManager.GAME_SPEED;
            transform.position = transformPosition;
            if (transform.position.y < -20)
            {
                gameObject.SetActive(false);
            }
        }
        
    }
    private bool cageup = false;
    void OnMouseDown(){
        Debug.Log("START CAGE UP");
        //GameManager.PAUSED = false;
        //Time.timeScale = 1;
        _spriteRenderer.sprite = secondState;
        var transformPosition = gameObject.transform.position;
        transformPosition.x = 3.64f;
        transform.position = transformPosition;
        cageup = true;
        
    }
}
