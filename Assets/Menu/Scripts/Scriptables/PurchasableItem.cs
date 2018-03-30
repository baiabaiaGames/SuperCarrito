using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "AIP/purchasable Item")]
public class PurchasableItem : ScriptableObject {

    public string id;
    public int quantity = 1;

}