using UnityEngine;
using System.Collections;

public class AlrPerro : MonoBehaviour {

    public Transform PerroPrefab;

    public float nextPerroTime = 10f;
    private float spawnRate = 1.5f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (nextPerroTime < Time.time)
        {
            Spawnperro();
            nextPerroTime = Time.time + spawnRate;

            spawnRate *= 5;
            spawnRate = Mathf.Clamp(spawnRate, 5f, 9f);
        }
    }


    void Spawnperro()
    {
       
        Vector3 spawnPos = transform.position + new Vector3(0, 0, 0);
        Instantiate(PerroPrefab, spawnPos, Quaternion.identity);
    }


}
