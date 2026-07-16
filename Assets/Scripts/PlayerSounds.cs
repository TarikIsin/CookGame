using UnityEngine;

public class PlayerSounds : MonoBehaviour {

    private Player player;
    private float footStepTimer;
    private float footStepTimerMax = .1f;


    private void Start() {
        player = GetComponent<Player>();
    }

    private void Update() {
        footStepTimer -= Time.deltaTime;
        if (footStepTimer < 0f) {
            footStepTimer = footStepTimerMax;

            if (player.IsWalking()) {
                float volume = 1f;
                SoundManager.Instance.PlayFootStepsSound(player.transform.position, volume);
            }
            
        }
    }
}
