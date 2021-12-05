using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientTile : MonoBehaviour
{
    AmbienSpawner AmbientSpawner;
    // Start is called before the first frame update
    void Start()
    {
        AmbientSpawner = GameObject.FindObjectOfType<AmbienSpawner>();
    }
    private void OnTriggerExit(Collider other)
    {
        AmbientSpawner.SpawnTile();
        Destroy(gameObject, 2);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
