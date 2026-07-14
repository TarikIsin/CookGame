using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class PlateKitchenObject : KitchenObject {

    [SerializeField] private List<KitchenObjectsSO> validKitchenObjectSOList;

    private List<KitchenObjectsSO> kitchenObjectSOList;

    private void Awake() {
        kitchenObjectSOList = new List<KitchenObjectsSO>();
    }
    public bool TryAddIngredient (KitchenObjectsSO kitchenObjectSO) {
        if (!validKitchenObjectSOList.Contains(kitchenObjectSO)) {
            // Not a valid ingredient for this plate
            return false;
        } else {

        }

            if (kitchenObjectSOList.Contains(kitchenObjectSO)) {
            // Already has this ingredient, cannot add it again
            return false;
        } else {             
            // Add the ingredient to the list
            kitchenObjectSOList.Add(kitchenObjectSO);
            return true;
        }
    }
}
