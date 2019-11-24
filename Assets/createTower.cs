using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createTower : MonoBehaviour
{
    public GameObject block;
    //public int numBlocks;
    public int nbLayers;
    public float brickX;
    public float brickY;

    // Start is called before the first frame update
    void Start()
    {
        buildTower();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            buildTower();
        }
    }

    void buildTower()
    {
        float epsilon = 0.005f;
        Vector3 rPos = transform.position;
        for (int h = 0; h < nbLayers; h++)
        {
            for (int i = 0; i < 3; i++)
            {
                Quaternion rot = Quaternion.identity;
                Vector3 rotEuler;

                Vector3 pos;
                if (h % 2 == 0) // If even number layer
                {
                    pos = new Vector3(i * (brickX + epsilon), h * (brickY + epsilon), brickX);
                    rotEuler = new Vector3(0, 0, 0);
                } else // If odd number layer
                {
                    pos = new Vector3(brickX, h * (brickY + epsilon), i * (brickX + epsilon));
                    rotEuler = new Vector3(0, 90, 0);
                }

                rot.eulerAngles = rotEuler;
                GameObject newBlock = Instantiate(block);
                Debug.Log("New Block!");
                newBlock.transform.rotation = rot;
                newBlock.transform.position = pos + rPos;
            }
        }

        /*
        float brickY = 0.07f;
        float brickX = 0.1f;
        float brickZ = 0.3f;
        float epsilon = 0.01f;
        Vector3 currentPos = transform.position;
        int currentAngle = 0;
        for(int i=0; i<numBlocks/3; i++)
        {
            Quaternion currentRot = Quaternion.Euler(0, currentAngle, 0);
            GameObject clone;
            Debug.Log("");
            if(currentAngle == 0)
            {
                currentAngle = 90;
                currentPos = currentPos + new Vector3(0, 0, )
                Debug.Log(currentPos);
                Instantiate(block, currentPos, currentRot);
                currentPos = currentPos + new Vector3(brickX + epsilon, 0, 0);
                Debug.Log(currentPos);
                Instantiate(block, currentPos, currentRot);
                currentPos = currentPos + new Vector3(brickX + epsilon, 0, 0);
                Debug.Log(currentPos);
                Instantiate(block, currentPos, currentRot);
                currentPos = currentPos + new Vector3(-2 * (brickX + epsilon), brickY + epsilon, 0);
            } else
            {
                currentAngle = 0;
                Debug.Log(currentPos);
                Instantiate(block, currentPos, currentRot);
                currentPos = currentPos + new Vector3(0, 0, brickX + epsilon);
                Debug.Log(currentPos);
                Instantiate(block, currentPos, currentRot);
                currentPos = currentPos + new Vector3(0, 0, brickX + epsilon);
                Debug.Log(currentPos);
                Instantiate(block, currentPos, currentRot);
                currentPos = currentPos + new Vector3(0, brickY + epsilon, -2 * (brickX + epsilon));
            }
        }
        */
    }
}

