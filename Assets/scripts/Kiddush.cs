using UnityEngine;

public class Kiddush : MonoBehaviour
{
    [SerializeField] private AudioClip prayerClip;
    private AudioSource audioSource;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();   
    }

    public void UseKiddushCup()
    {
        if (prayerClip != null)
        {
            audioSource.clip = prayerClip;
            audioSource.Play();
        }
    }
}
