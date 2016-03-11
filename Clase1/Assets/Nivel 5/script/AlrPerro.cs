using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class AlrPerro : MonoBehaviour {
    public AudioClip lobowalk;
    private AudioSource Sound;
    public Transform PerroPrefab;

    public float nextPerroTime = 10f;
    private float spawnRate = 1.5f;

    // Use this for initialization
    void Start()
    {
        Sound = GetComponent<AudioSource>();
        Sound.clip = lobowalk;
    }

    // Update is called once per frame
    void Update()
    {
        if (nextPerroTime < Time.time)
        {
            Spawnperro();
            nextPerroTime = Time.time + spawnRate;

            spawnRate *= 5;
            spawnRate = Mathf.Clamp(spawnRate, 4f, 9f);
            Sound.clip = lobowalk;
            Sound.Play();
        }
    }


    void Spawnperro()
    {
       
        Vector3 spawnPos = transform.position + new Vector3(0, 0, 0);
        Instantiate(PerroPrefab, spawnPos, Quaternion.identity);
    }


}
