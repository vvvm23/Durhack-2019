using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class targetSpawner : MonoBehaviour
{
    public int maxTargets;
    static System.Random random = new System.Random();
    public GameObject targetObject;
    int nbActiveTargets;
    // Start is called before the first frame update
    void Start()
    {
        //random = new System.Random();
        nbActiveTargets = 0;
    }

    public void decrementCount()
    {
        nbActiveTargets -= 1;

    }

    // Update is called once per frame
    void Update()
    {
        if (nbActiveTargets < maxTargets)
        {
            if (random.Next(0, 100) < 2)
            {
                Vector3 rPos = transform.position;
                nbActiveTargets++;
                GameObject clone = Instantiate(targetObject);

                int speed = random.Next(0, 5);
                int direction = random.Next(0, 2);

                float randX = (float)(random.NextDouble() * transform.lossyScale.x);
                float randZ = (float)(random.NextDouble() * transform.lossyScale.z);

                Vector3 velocity;
                if (direction == 0)
                {
                    velocity = new Vector3((float)speed, 0, 0);
                } else
                {
                    velocity = new Vector3(0, 0, (float)speed);
                }

                Vector3 position = rPos + new Vector3(randX, 0, randZ);
                clone.transform.position = position;

            }
        }


    }
}
