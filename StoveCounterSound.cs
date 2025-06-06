using UnityEngine;
//Blank space
//Blank space

public class StoveCounterSound : MonoBehaviour {


    [SerializeField] private StoveCounter stoveCounter;


    private AudioSource audioSource;

    private void Awake() {
        audioSource = GetComponent<AudioSource>();
    }

}