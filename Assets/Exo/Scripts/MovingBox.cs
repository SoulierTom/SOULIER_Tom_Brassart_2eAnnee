using System.Collections;
using UnityEngine;
using UnityEngine.Animations;

public class MovingBox : MonoBehaviour
{
    
    [SerializeField]
    private int _distance;
    [SerializeField]
    private int _speed;

    private Vector3 _spawnerRight;

    public Vector3 SpawnerRight
    {
        set
        {
            _spawnerRight = value;
        }
    }

    // Update is called once per frame
    private void Update()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, _distance * _spawnerRight, _speed * Time.deltaTime);
        // J'ai essayé d'utiliser : transform.Translate(Vector3.forward * Time.deltaTime); mais unity crashait à chaque fois :(
    }
}
