using UnityEngine;
using UnityEngine.UI;
public class Trap : MonoBehaviour
{
    public GameObject itemPrefab;
    public Sprite icon;
    public string itemName;
    [TextArea(4, 16)]
    public string description;
    public float weight = 0;
    public int quantity = 1;
    // for bundles of items, such as arrows or coins
    public int maxStackableQuantity = 1;
    // if false, item will be used when picked up
    public bool isStorable = false;
    // if true, item will be destroyed (or quantity reduced) when used
    public bool isConsumable = true;
    bool isPickupOnCollision = false;
    private void Start()
    {
        if (isPickupOnCollision)
        {
            gameObject.GetComponent<Collider>().isTrigger =
            true;
        }
    }
    void Update()
    {
    }


    public void Interact()
    {
        Debug.Log("Activated " + transform.name);
        Use();
        
    }
    void Store()
    {
        Debug.Log("Storing " + transform.name);
        // Todo
        Destroy(gameObject);
    }
    void Use()
    {

        healthManager.Hit(-80);
        Debug.Log("OUCH");

    }
    private HealthManager healthManager;
    private void OnTriggerEnter(Collider collider)
    {
        if (isPickupOnCollision)
        {
            if (collider.tag == "Player")
            {
                Interact();
            }
        }

    }

}
