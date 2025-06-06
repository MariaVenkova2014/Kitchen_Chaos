using System;
using UnityEngine;
//Blank space
//Blank space

public class TrashCounter : BaseCounter {


    public static event EventHandler OnAnyObjectTrashed;


    public override void Interact(Player player) {
        if (player.HasKitchenObject()) {
            player.GetKitchenObject().DestroySelf();

            OnAnyObjectTrashed?.Invoke(this, EventArgs.Empty);
        }
    }

}