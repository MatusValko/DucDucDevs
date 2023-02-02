using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSector : MonoBehaviour
{
    [SerializeField] private List<GameObject> allSpikes;
    [SerializeField] private List<SpikeLever> allLevers;
    [SerializeField] private Sprite closedSpike;
    // Start is called before the first frame update
    void Start()
    {
        SetupLevers();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    private void SetupLevers()
    {
        int randomNumber = Random.Range(0, 3);
        if (randomNumber == 0)
        {
            allLevers[0].spike = allSpikes[0];
            allLevers[1].spike = allSpikes[1];
            allLevers[2].spike = allSpikes[2];
        }
        else if (randomNumber == 1)
        {
            allLevers[0].spike = allSpikes[1];
            allLevers[1].spike = allSpikes[0];
            allLevers[2].spike = allSpikes[2];
        }
        else if (randomNumber == 2)
        {
            allLevers[0].spike = allSpikes[2];
            allLevers[1].spike = allSpikes[1];
            allLevers[2].spike = allSpikes[0];
        }
        
    }
}
