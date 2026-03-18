using UnityEngine;

/// <summary>
/// Rotates a directional light to simulate a day/night cycle.
/// </summary>
public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Duration of a full day in seconds.")]
    public float dayLengthInSeconds = 120f; // Default: 2 minutes for a full cycle

    private void Update()
    {
        // Calculate degrees per second (360° for a full rotation)
        float rotationSpeed = 360f / dayLengthInSeconds;

        // Rotate around the X-axis to simulate the sun moving across the sky
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}