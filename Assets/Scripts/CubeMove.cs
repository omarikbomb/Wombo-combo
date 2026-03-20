using UnityEditor.Callbacks;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float Speed = 0;
    public Rigidbody2D LeftCube;
    public Rigidbody2D RightCube;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        LeftCube = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (MousePos.x < 0)
            {
                
            }
        }
    }

    void FixedUpdate()
    {
        LeftCube.linearVelocity = transform.up * Speed;
        RightCube.linearVelocity = transform.up * Speed
    }
}
