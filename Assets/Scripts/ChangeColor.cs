using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
   
    private Color[] colors = new Color[] { Color.red, Color.yellow, Color.blue , Color.white}; //renk havuzumuz
    public int currentColor, length;
    private Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        
        rend = GetComponent<Renderer>();

        currentColor = 3;
        length = colors.Length - 1;
        rend.material.color = colors[currentColor];
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, 100))
            {
                currentColor = (currentColor + 1) % length;
                rend.material.color = colors[currentColor];
            }
        }
    }
}
