using TMPro;
using UnityEngine;

public class GameOverUI : MonoBehaviour {

    [SerializeField] private TextMeshProUGUI recipesDeliveredText;

    [SerializeField] private TextMeshProUGUI countdownText;


    private void Start() {
        GameManager.Instance.OnStageChanged += GameManager_OnStageChanged;

        Hide();
    }

    private void GameManager_OnStageChanged(object sender, System.EventArgs e) {
        if (GameManager.Instance.IsGameOver()) {
            Show();

            recipesDeliveredText.text = DeliveryManager.Instance.GetSuccessfulRecipesAmount().ToString();
        } else {
            Hide();
        }
    }

    private void Show() {
        gameObject.SetActive(true);
    }
    private void Hide() {
        gameObject.SetActive(false);
    }
}
