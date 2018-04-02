using UnityEngine;

[CreateAssetMenu (menuName = "AIP/purchasable Item")]
public class Items : ScriptableObject {

    public string id;
    public float price = 700;
    public int quantity = 1;
    public Mesh mesh;

}