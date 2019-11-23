using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createTower : MonoBehaviour
{
    public GameObject block;
    public int numBlocks;
    // Start is called before the first frame update
    void Start()
    {
        buildTower();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void buildTower()
    {
        float brickY = 0.07f;
        float brickX = 0.1f;
        float brickZ = 0.3f;
        float epsilon = 0.01f;
        Vector3 currentPos = transform.position;
        int currentAngle = 0;
        for(int i=0; i<numBlocks/3; i++)
        {
            Quaternion currentRot = Quaternion.Euler(0, currentAngle, 0);
            if(currentAngle == 90)
            {
                currentAngle = 0;
            } else
            {
                currentAngle = 90;
            }
            Instantiate(block, currentPos, currentRot);
            currentPos = currentPos + new Vector3(brickX + epsilon, 0, 0);
            Instantiate(block, currentPos, currentRot);
            currentPos = currentPos + new Vector3(brickX + epsilon, 0, 0);
            Instantiate(block, currentPos, currentRot);
            currentPos = currentPos + new Vector3(-2*(brickX + epsilon), brickY + epsilon, 0);


        }
    }
}

