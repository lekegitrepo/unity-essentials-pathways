using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // Variable to control how many seconds it takes for a full day to pass
    [Tooltip("How many seconds in real-time it takes for one full in-game day.")]
    [SerializeField] private float secondsPerDay = 60f;

    // The speed at which the light rotates
    private float rotationSpeed;

    // Update is called once per frame
    private void Update()
    {
        // Calculate the speed based on the seconds per day
        rotationSpeed = 360f / secondsPerDay * Time.deltaTime;

        // Rotate the directional light around the X-axis to simulate a day passing
        transform.Rotate(rotationSpeed, 0f, 0f);
    }
}
