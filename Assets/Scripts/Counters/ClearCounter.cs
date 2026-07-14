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
                if (player.GetKitchenObject().TryGetPlate(out PlateKitchenObject plateKitchenObject)) {
                    // Player is holding a plate
                    if (plateKitchenObject.TryAddIngredient(GetKitchenObject().GetKitchenObjectsSO())) {
                        GetKitchenObject().DestroySelf();
                    }
                } else {
                    // Player is not holding a plate but something else
                    if (GetKitchenObject().TryGetPlate(out plateKitchenObject)) {
                        // Counter is holding a plate
                        if (plateKitchenObject.TryAddIngredient(player.GetKitchenObject().GetKitchenObjectsSO())) {
                            player.GetKitchenObject().DestroySelf();
                        }
                    }
                }
            } else {
                // Player not carrying something
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }
}
