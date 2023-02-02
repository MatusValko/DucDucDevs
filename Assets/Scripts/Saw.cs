using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Saw : MonoBehaviour
{
    public Vector3 targetPosition;
    public Vector3 lastposition;
    [SerializeField] private float speed = 5;
    bool right = true;
    bool left = false;
    public bool ismoving = true;
    [SerializeField] private GameObject lever;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector3 = new Vector3(2,0,0);
        if (ismoving)
        {
            
            if (right)
            {
            
                transform.position += (transform.right+vector3) * speed * Time.deltaTime;
                //Debug.Log(transform.position.x);
                if (transform.position.x > 5)
                {
                    left = true;
                    right = false;
                }
            }
            if (left)
            {
                transform.position += -(transform.right+vector3) * speed * Time.deltaTime;
                if (transform.position.x < -5)
                {
                    left = false;
                    right = true;
                }
            }
            
            
            
            
            
            
        }
        
        
   
        
        
        
    }        
        
        /*
        Vector3 directionToMove = targetPosition - transform.position;
        directionToMove = directionToMove.normalized * Time.deltaTime * speed;
        float maxDistance = Vector3.Distance(transform.position, targetPosition);
        lastposition = transform.position + Vector3.ClampMagnitude(directionToMove, maxDistance);

        targetPosition.x +=  lastposition.x;
        */
        /*
        if (transform.position.x > 0.15)
        {
            Debug.Log(transform.position.x);
            Debug.Log("PRAVY OKRAJ");
            speed = -speed;
        }
        if (transform.position.x < -0.15)
        {
            Debug.Log("LAVY OkRAJ");
            speed = -speed;
        }*/
        
    
   
    

    private void moveSaw()
    {
        var transformPosition = transform.position;
        transformPosition.x = transformPosition.x + speed;
        transform.position = transformPosition;
        if (transformPosition.x > 0.15)
        {
            speed = -speed;
        }
        if (transformPosition.x < -0.15)
        {
            speed = -speed;
        }
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
