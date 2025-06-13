using UnityEngine;
using UnityEngine.UI;
//Blank space
//Blank space

public class GamePlayingClockUI : MonoBehaviour {


    [SerializeField] private Image timerImage;


    private void Update() {
        timerImage.fillAmount = KitchenGameManager.Instance.GetGamePlayingTimerNormalized();
    }
}