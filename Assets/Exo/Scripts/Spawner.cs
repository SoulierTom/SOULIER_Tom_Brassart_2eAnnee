using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private MovingBox _movingBox;

    [SerializeField]
    private float _spawnInterval;

    private Vector3 _spawnPosition;

    private void Start()
    {
        _spawnPosition = transform.position;
        StartCoroutine(SpawnSphere(_spawnInterval, _movingBox));
    }

    private IEnumerator SpawnSphere(float interval, MovingBox sphere)
    {
        while (true)
        {
            yield return new WaitForSeconds(interval);
            MovingBox newSphere = Instantiate(sphere, _spawnPosition, Quaternion.identity);
        }
    }
}