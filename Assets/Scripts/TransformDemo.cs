using UnityEngine;

public class TransformDemo : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 100f;
    public float scaleSpeed = 1f;
    public float teleportDistance = 3f;

    void Update()
    {
        // WASD - Move (Translate)
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

        // Q/E - Move Up/Down
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }

        // Arrow Keys - Rotate
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(Vector3.right, -rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(Vector3.right, rotateSpeed * Time.deltaTime);
        }

        // Z/X - Rotate on Z axis (Roll)
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(Vector3.forward, -rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.X))
        {
            transform.Rotate(Vector3.forward, rotateSpeed * Time.deltaTime);
        }

        // R/F - Scale Up/Down
        if (Input.GetKey(KeyCode.R))
        {
            transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.F))
        {
            transform.localScale -= Vector3.one * scaleSpeed * Time.deltaTime;
            if (transform.localScale.x < 0.1f)
            {
                transform.localScale = Vector3.one * 0.1f;
            }
        }

        // T - Reset Transform
        if (Input.GetKeyDown(KeyCode.T))
        {
            transform.position = Vector3.zero;
            transform.rotation = Quaternion.identity;
            transform.localScale = Vector3.one;
        }

        // Space - Jump (Instant movement)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += Vector3.up * 2f;
        }

        // IJKL - Teleport (GetKeyDown for instant single press)
        if (Input.GetKeyDown(KeyCode.I))
        {
            transform.position += Vector3.forward * teleportDistance;
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            transform.position += Vector3.back * teleportDistance;
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            transform.position += Vector3.left * teleportDistance;
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            transform.position += Vector3.right * teleportDistance;
        } 
    }
}
