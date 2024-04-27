using UnityEngine;

public class FlowerAudioTrigger : MonoBehaviour
{
    private AudioSource audioSource;  // AudioSource component

    void Awake()
    {
        // Ensure there is an AudioSource component and it has a clip assigned
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null || audioSource.clip == null)
        {
            Debug.LogError("AudioSource or clip not found on the flower GameObject", this);
            this.enabled = false; // Disable the script if setup is incorrect
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the collider belongs to the Player
        if (other.CompareTag("Player"))
        {
            // Play the audio clip if not already playing
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }
}
