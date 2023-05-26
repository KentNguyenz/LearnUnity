using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpawnGameObject : MonoBehaviour
{
    [SerializeField]
    private Transform spawnPoint;
    [SerializeField]
    private GameObject spawnObject;
    private GameObject runtimeSpawnGO;
    private float timeToDestroy = 2f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           runtimeSpawnGO = Instantiate(spawnObject, spawnPoint);
            if(runtimeSpawnGO != null)
            {
                DestroyGO();
            }
        }
    }
    private void DestroyGO()
    {
        Destroy(runtimeSpawnGO,timeToDestroy);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
