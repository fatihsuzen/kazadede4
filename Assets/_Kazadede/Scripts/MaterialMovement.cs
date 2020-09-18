using UnityEngine;

public class MaterialMovement : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }
}