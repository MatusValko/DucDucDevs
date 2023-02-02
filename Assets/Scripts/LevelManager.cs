using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> allSectors;
    [SerializeField] private List<Sector> inGameSectors;
    [SerializeField] private Sector lastSector;
    
    [SerializeField] private TextMeshProUGUI Score;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "SCORE: " + score;
        //GenerateSector();
        Checkifunderplayer();
        /*if (Input.GetButtonDown("Fire1"))
        {
            Unpause();
        }*/
    }

    void PauseGame ()
    {
        Debug.Log("PAUSE");
        Time.timeScale = 0;
    }
    
    private void Unpause()
    {
        Debug.Log("UNPAUSE");
        Time.timeScale = 1;
    }


    private void Checkifunderplayer()
    {
        lastSector = inGameSectors[0];
        if (lastSector.transform.position.y < -10)
        {
            score += 1;
            inGameSectors.RemoveAt(0);
            GenerateSector();
            //PauseGame();
        }
        
    }


    private void GenerateSector()
    {
        int randomNumber = Random.Range(0, allSectors.Count);
        GameObject randomSector = allSectors[randomNumber];
        
        randomSector = Instantiate(randomSector, transform );
        var transformPosition = randomSector.transform.position;
        transformPosition.y += 20;
        inGameSectors.Add(randomSector.GetComponent<Sector>());

        Debug.Log(randomSector);


    }
}
