using UnityEngine;
//Blank space
//Blank space

public class TrashCounter : BaseCounter {


    public override void Interact(Player player) {
        if (player.HasKitchenObject()) {
            player.GetKitchenObject().DestroySelf();
        }
    }
}