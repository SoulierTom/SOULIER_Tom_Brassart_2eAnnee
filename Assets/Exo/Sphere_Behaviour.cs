using System.Collections;
using UnityEngine;
using UnityEngine.Animations;

public class Sphere_Behaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject _sphere;
    [SerializeField]
    private int _distance;
    [SerializeField] [Min(50)]
    private int _speed;
    [SerializeField] [Min(2.0f)]
    private float _lifetime;
    
    private LookAtConstraint _lookAtSphereReference;

    public LookAtConstraint LookAtSphereReference
    {
        set 
        {
            _lookAtSphereReference = value;
        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        StartCoroutine(DestroySphere(_lifetime, _sphere));
        _lookAtSphereReference.AddSource;
    }

    // Update is called once per frame
    private void Update()
    {
        _sphere.transform.position = Vector3.MoveTowards(_sphere.transform.position, _distance*Vector3.right, _speed*Time.deltaTime);
    }

    private IEnumerator DestroySphere(float interval, GameObject sphere)
    {
        yield return new WaitForSeconds(interval);
        Destroy(sphere);
        StartCoroutine(DestroySphere(interval, sphere));
    }
}
