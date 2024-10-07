using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HandleDirectionalInput(Vector2 direction)
    {
        // Right
        if(direction.x > 0)
        {
            print("Right");
        }
        // Left
        else if (direction.x < 0)
        {
            print("Left");
        }
        // Up
        else if (direction.y > 0)
        {
            transform.position = new Vector2(0, 0.08f);

            print("Up");
        }
        // Down
        else if (direction.y < 0)
        {
            print("Down");
        }
    }

}
