using UnityEngine;

public class DayToNight : MonoBehaviour
{
    [Header("Day/Night Cycle Settings")]

    [Tooltip("How many real-time seconds it takes for a full in-game day.")]
    [SerializeField] private float dayLengthInSeconds = 120f;

    [Tooltip("Axis the light rotates around. X is typical for sun movement.")]
    [SerializeField] private Vector3 rotationAxis = Vector3.right;

    private float rotationSpeed;

    void Start()
    {
        // Calculate how fast the light should rotate
        // 360 degrees divided by total seconds in a day
        rotationSpeed = 360f / dayLengthInSeconds;
    }

    void Update()
    {
        // Rotate the light continuously over time
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);
    }
}
