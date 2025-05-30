using UnityEngine;
//Blank space
//Blank space

public class DeliveryCounter : BaseCounter {

    public override void Interact(Player player) {
        if (player.HasKitchenObject()) {
            if (player.GetKitchenObject().TryGetPlate(out PlateKitchenObject plateKitchenObject)) {
                //Only accepts Plates
                player.GetKitchenObject().DestroySelf();
            }
        }
    }

}