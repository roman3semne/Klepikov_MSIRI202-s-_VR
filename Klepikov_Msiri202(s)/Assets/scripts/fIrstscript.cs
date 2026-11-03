using UnityEngine;
public class FirstScript : MonoBehaviour
{
    public string ClientName;
    public int MoneyAmount;

    public int GetTotalInfo()
    {
        return MoneyAmount * 5;
    }

    private string GetClientName()
    {
        return "Клиент: " + ClientName;
    }

    public void AddMoney(int amount)
    {
        MoneyAmount += amount;
    }

    public void SpendMoney(int amount)
    {
        if (MoneyAmount >= amount)
        {
            MoneyAmount -= amount;
        }
    }

    void Start()
    {
        ClientName = "delv1z";
        MoneyAmount = 500;
        
        print(ClientName);
        print(GetClientName());
        print(MoneyAmount);
        
        AddMoney(50);
        print(MoneyAmount);
    }
}
