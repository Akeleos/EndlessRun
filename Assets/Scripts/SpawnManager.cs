using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float delay = 1;
    private float repeatRate = 3;
    public GameObject[] obj;
     
    private Vector3  spawnPosition = new Vector3(0, 1, 60);
    private Controller controller;
    

    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", delay, repeatRate);
        controller = GameObject.Find("Player").GetComponent<Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        int randomIndex = Random.Range(0, obj.Length);
        if (controller.gameOver == false && controller.won == false) { Instantiate(obj[randomIndex], spawnPosition, obj[randomIndex].transform.rotation); }
        
        
    }
}
