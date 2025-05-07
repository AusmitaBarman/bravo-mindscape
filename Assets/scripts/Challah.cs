using UnityEngine;

public class Challah : MonoBehaviour
{
    [SerializeField] private AudioClip audioClip;
    private AudioSource audioSource;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void UseChallah()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }
}
