using UnityEngine;
public class ClearCounter : BaseCounter {

    [SerializeField] private KitchenObjectsSO kitchenObjects;

    public override void Interact(Player player) {
        if (!HasKitchenObject()) {
            // There is no KitchenObject on the counter
            if (player.HasKitchenObject()) {
                // Player is carrying something
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else {
                // Player not carrying something
            }
        } else {
            // There is KitchenObject on the counter
            if (player.HasKitchenObject()) {
                // Player is carrying something
                if (player.GetKitchenObject() is PlateKitchenObject) {

                }
            }
            else {
                // Player not carrying something
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }
}
