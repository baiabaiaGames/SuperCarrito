using UnityEngine;

[CreateAssetMenu (menuName = "AIP/ Coins")]
public class PurchasableCoins : ScriptableObject {
	public string id;
	public int quantity = 700;
	public string price_rm = "$ 0.99";

}