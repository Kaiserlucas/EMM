using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableBehaviour : MonoBehaviour
{

    public Transform myPrefab;
    public Transform smokeEffect;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            float randomX = UnityEngine.Random.Range(-5f, 5f);
            float randomZ = UnityEngine.Random.Range(-5f, 5f);
            Transform coin = Instantiate(myPrefab, new Vector3(randomX + transform.position.x, 1, randomZ), myPrefab.rotation);
            coin.transform.SetParent(this.transform);

            if(smokeEffect != null)
            {
                Transform smoke = Instantiate(smokeEffect, new Vector3(randomX + transform.position.x, 1, randomZ), smokeEffect.rotation);
                smoke.transform.SetParent(coin.transform);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
