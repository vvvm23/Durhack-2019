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
        Vector3 currentPos = transform.position;
        int currentAngle = 0;
        for(int i=0; i<numBlocks/3; i++)
        {
            Quaternion currentRot = Quaternion.Euler(currentAngle, 0, 0);
            currentAngle += 90;
            Instantiate(block, currentPos, Quaternion.identity);
            currentPos = currentPos + new Vector3(brickX, 0, 0);
            Instantiate(block, currentPos, Quaternion.identity);
            currentPos = currentPos + new Vector3(brickX, 0, 0);
            Instantiate(block, currentPos, currentRot);
            currentPos = currentPos + new Vector3(-2*brickX, brickY, 0);


        }
    }
}

