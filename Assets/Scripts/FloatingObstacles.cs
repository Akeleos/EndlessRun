using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingObstacles : MonoBehaviour
{
    public float moveSpeed = .0f; // custom de�i�ken
    private Controller controller; // referans
    private float leftBound = -15; //objelerin silinece�i d�zlem s�n�r�
    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.Find("Player").GetComponent<Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        if(controller.gameOver == false && controller.won == false) {transform.Translate(Vector3.right * Time.deltaTime * moveSpeed); }
        if(transform.position.z < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
        
    }
}
