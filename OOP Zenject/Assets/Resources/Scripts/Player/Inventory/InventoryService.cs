using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class InventoryService : MonoBehaviour,IInventoryService
{
    [SerializeField]private List<Item> items;

    public InventoryService()
    {
        items = new List<Item>();
    }

    public void AddItem(Item item)
    {
        items.Add(item);
        Debug.Log($"�������� ������� {item.name} � ���������.");
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(items.Count != 0)
            {
                RemoveItem(items[0]);
            }
            else
            {
                Debug.LogWarning("������ ������ �����������!");
            }
        }
    }
    public void RemoveItem(Item item)
    {
        items.Remove(item);
        Debug.Log($"������ ������� {item.name} �� ���������.");
    }

    public Item PickUpNearestItem(Vector3 playerPosition)
    {
        Item nearestItem = null;
        float nearestDistance = Mathf.Infinity;

        // ����� ��� ������� � ����� "Item" � �����
        GameObject[] foundItems = GameObject.FindGameObjectsWithTag("Item");

        // �������� �� ���� ��������� �������� � ������� ��������� � ������
        foreach (GameObject itemObject in foundItems)
        {
            // �������� ��������� Item �� �������
            Item item = itemObject.GetComponent<Item>();

            if (item != null)
            {
                // ��������� ���������� ����� ������� � ���������
                float distance = Vector3.Distance(playerPosition, itemObject.transform.position);

                // ���� ������� ����� � ������, ��� ���������� ��������� �������, �� ������� ���
                if (distance < nearestDistance)
                {
                    nearestDistance = distance;
                    nearestItem = item;
                }
            }
        }
        items.Add(nearestItem);
        
        return nearestItem;
      
    }

    public void UseItem(Item item)
    {
        // ������ ������������� ��������
        // ...
        Debug.Log($"����������� ������� {item.name}.");
    }

    public List<Item> GetItems()
    {
        return items;
    }


}
