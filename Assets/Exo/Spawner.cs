using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    LookAtConstraint _lookAtReference;

    [SerializeField]
    private Sphere_Behaviour _spherePrefab;
    
    [SerializeField] [Range(0.2f, 5.0f)]
    private float _spawnInterval;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnSphere(_spawnInterval, _spherePrefab));
    }

    private IEnumerator SpawnSphere(float interval, Sphere_Behaviour sphere)
    {
        yield return new WaitForSeconds(interval);
        Sphere_Behaviour newSphere = Instantiate(sphere, new Vector3(0,0,0), Quaternion.identity);
        newSphere.LookAtSphereReference = _lookAtReference;
        StartCoroutine(SpawnSphere(interval, sphere));

        
    }
}