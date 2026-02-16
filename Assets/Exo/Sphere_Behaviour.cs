using System.Collections;
using UnityEngine;
using UnityEngine.Animations;

public class Sphere_Behaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject _sphere;
    [SerializeField] [Min(50)]
    private int _distance;
    [SerializeField] [Min(50)]
    private int _speed;
    [SerializeField] [Min(2.0f)]
    private float _lifetime;
    
    private Vector3 _spawnerRight;
    
    public Vector3 SpawnerRight
    {
        set 
        {
            _spawnerRight = value;
        }
    }

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
        _lookAtSphereReference.AddSource(new ConstraintSource { sourceTransform = _sphere.transform, weight = 0.5f });
    }

    // Update is called once per frame
    private void Update()
    {
        _sphere.transform.position = Vector3.MoveTowards(_sphere.transform.position, _distance* _spawnerRight, _speed*Time.deltaTime);
    }

    private IEnumerator DestroySphere(float interval, GameObject sphere)
    {
        yield return new WaitForSeconds(interval);
        Destroy(sphere);
        
        _lookAtSphereReference.RemoveSource(0);
        StartCoroutine(DestroySphere(interval, sphere));
    }
}
