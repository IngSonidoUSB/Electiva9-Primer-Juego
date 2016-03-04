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

            nextPerroTime = Time.time + spawnRate;

            spawnRate *= 5f;
            spawnRate = Mathf.Clamp(spawnRate, 1f, 2f);
        }
    }


}
