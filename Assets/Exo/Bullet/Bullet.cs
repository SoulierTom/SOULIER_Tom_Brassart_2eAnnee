using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float _bulletSpeed;
   
    
    private void Update()
    {
        transform.Translate(transform.up * Time.deltaTime * _bulletSpeed);
    }
}
