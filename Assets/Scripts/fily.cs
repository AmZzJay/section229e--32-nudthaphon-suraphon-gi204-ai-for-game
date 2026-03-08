using UnityEngine;

public class FlyAndRotate : MonoBehaviour
{
    public float flySpeed = 5f;
    public float rotateSpeed = 100f;

    void Update()
    {
        // บินไปทางแกน X
        transform.Translate(Vector3.left * flySpeed * Time.deltaTime);

        // บิดหมุนตามแกน X
        transform.Rotate(-rotateSpeed * Time.deltaTime, 0f, 0f);
    }
}