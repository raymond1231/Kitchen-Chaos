using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerCounter : BaseCounter
{

    public event EventHandler OnPlayerGrabbedObejct;

    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public override void Interact(Player player)
    {
        if (!player.HasKitchenObject()) 
        {
            // Player is not carrying anything
            Transform KitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);
            KitchenObjectTransform.GetComponent<KitchenObject>().SetKitchenObjectParent(player);
            OnPlayerGrabbedObejct?.Invoke(this, EventArgs.Empty);
        }
        
        
    }

    
}
