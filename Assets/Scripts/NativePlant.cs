using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ProximityAudioTrigger1 : MonoBehaviour
{
    public float triggerDistance = 5f; // The distance at which the audio will play
    private AudioSource audioSource;
    private GameObject player;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void UpdateAudio()
    {
        // Check the distance between the player and this object
        float distanceToPlayer = Vector3.Distance(player.transform.position, transform.position);

        // If the player is close enough and the audio is not already playing, play it
        if (distanceToPlayer <= triggerDistance && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
