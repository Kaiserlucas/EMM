using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableBehaviour : MonoBehaviour
{

    public Transform myPrefab;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            float randomX = UnityEngine.Random.Range(-5f, 5f);
            float randomZ = UnityEngine.Random.Range(-5f, 5f);
            Instantiate(myPrefab, new Vector3(randomX, 1, randomZ), myPrefab.rotation);
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
