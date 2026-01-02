using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource popSound;

    public void playPop() {
        popSound.Play();
    }
}