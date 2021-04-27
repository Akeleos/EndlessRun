using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPosition; //arkaplan baþlangýç pozisyonu
    private float repeatWidth; //tekrar etme sýklýðý

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.z+50;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < startPosition.z - repeatWidth)
        {
            transform.position = startPosition;
        }
    }
}
