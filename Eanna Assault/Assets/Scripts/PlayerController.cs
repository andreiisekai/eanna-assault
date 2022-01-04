using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("General")]
    [Tooltip("In ms^-1")][SerializeField] float moveSpeed = 20f;
    [Tooltip("In m")] [SerializeField] float xRange = 10f;
    [Tooltip("In m")] [SerializeField] float yRange = 5f;
    [SerializeField] GameObject[] guns;

    [Header("Screen-Position Based")]
    [SerializeField] float positionPitchFactor = -2f;
    [SerializeField] float positionYawFactor = 3f;

    [Header("Control Based")]
    [SerializeField] float verticalInputPitchFactor = -30f;
    [SerializeField] float horizontalInputRollFactor = -30f;

    float horizontalInput, verticalInput;
    bool isControlEnabled = true;
    bool fireInput;
    
    // Update is called once per frame
    void Update()
    {
        if(isControlEnabled)
        {
            ProcessPlayerInput();
        }
    }

    void OnPlayerDeath()  // referenced by string
    {
        isControlEnabled = false;
    }

    private void ProcessPlayerInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        fireInput = Input.GetButton("Fire");

        ProcessTranslation();
        ProcessRotation();
        ProcessFiring();
    }

    private void ProcessRotation()
    {
        float pitchDueToPosition = transform.localPosition.y * positionPitchFactor;
        float pitchDueToVerticalControl = verticalInput * verticalInputPitchFactor;
        float pitch = pitchDueToPosition + pitchDueToVerticalControl;

        float yaw = transform.localPosition.x * positionYawFactor;
        
        float roll = horizontalInput * horizontalInputRollFactor;

        transform.localRotation = Quaternion.Euler(pitch, yaw, roll);
    }

    void ProcessTranslation()
    {
        float xOffset = horizontalInput * moveSpeed * Time.deltaTime;
        float yOffset = verticalInput * moveSpeed * Time.deltaTime;

        float xPos = transform.localPosition.x + xOffset;
        float yPos = transform.localPosition.y + yOffset;

        float xPosClamped = Mathf.Clamp(xPos, -xRange, xRange);
        float yPosClamped = Mathf.Clamp(yPos, -yRange, yRange);

        transform.localPosition = new Vector3(xPosClamped, yPosClamped, transform.localPosition.z);
    }

    void ProcessFiring()
    {
        FireGuns(fireInput);
    }

    void FireGuns(bool enable)
    {
        foreach (GameObject gun in guns)
        {
            gun.SetActive(enable);
        }
    }
}
