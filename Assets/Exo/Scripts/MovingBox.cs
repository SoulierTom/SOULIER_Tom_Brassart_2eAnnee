using UnityEngine;

public class MovingBox : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
