using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Tooltip("In ms^-1")][SerializeField] float xMoveSpeed = 10f;
    [Tooltip("In ms^-1")] [SerializeField] float yMoveSpeed = 10f;
    [Tooltip("In m")] [SerializeField] float xRange = 10f;
    [Tooltip("In m")] [SerializeField] float yRange = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float xOffset = horizontalInput * xMoveSpeed * Time.deltaTime;
        float yOffset = verticalInput * yMoveSpeed * Time.deltaTime;
        float xPos = transform.localPosition.x + xOffset;
        float yPos = transform.localPosition.y + yOffset;
        float xPosClamped = Mathf.Clamp(xPos, -xRange, xRange);
        float yPosClamped = Mathf.Clamp(yPos, -yRange, yRange);
        print("X= " + xPos + " Y= " + yPos);
        print("xPosClamped= " + xPosClamped + " yPosClamped= " + yPosClamped);
        transform.localPosition = new Vector3(xPosClamped, yPosClamped, transform.localPosition.z);
        //transform.Translate(new Vector3(xPos, yPos, 0));
    }
}
