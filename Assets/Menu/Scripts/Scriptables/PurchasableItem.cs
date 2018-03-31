using UnityEngine;

[CreateAssetMenu (menuName = "AIP/purchasable Item")]
public class PurchasableItem : ScriptableObject {

    public string id;
    public float in_game_currency_price = 700;
    public string price_rm = "$ 0.99";
    public int quantity = 1;
    public Mesh mesh;

}