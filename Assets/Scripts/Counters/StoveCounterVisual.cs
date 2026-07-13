using UnityEngine;

public class StoveCounterVisual : MonoBehaviour {


    [SerializeField] private StoveCounter stoveCounter;
    [SerializeField] private GameObject stoveGameObject;
    [SerializeField] private GameObject particlesGameObject;

    private void Start()
    {
        stoveCounter.OnStateChanged += StoveCounter_OnStateChanged;
    }

    private void StoveCounter_OnStateChanged(object sender, StoveCounter.OnStateChangedEventArgs e)
    {
        switch (e.state)
        {
            case StoveCounter.State.Idle:
                stoveGameObject.SetActive(false);
                particlesGameObject.SetActive(false);
                break;
            case StoveCounter.State.Frying:
                stoveGameObject.SetActive(true);
                particlesGameObject.SetActive(true);
                break;
            case StoveCounter.State.Fried:
                stoveGameObject.SetActive(true);
                particlesGameObject.SetActive(true);
                break;
            case StoveCounter.State.Burned:
                stoveGameObject.SetActive(false);
                particlesGameObject.SetActive(false);
                break;
        }
    }
}
