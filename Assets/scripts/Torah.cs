using UnityEngine;

public class Torah : MonoBehaviour
{

    [SerializeField] private AudioClip prayerReading;
    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayTorahReading()
    {
        if (prayerReading != null)
        {
            Debug.Log("Torah Pressed");
            audioSource.clip = prayerReading;
            audioSource.Play();
        }

    }
}
