using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItemAction : PlayerAction
{
    public override void Execute(GameObject playerObject)
    {
       
        IInventoryService inventoryService = playerObject.GetComponent<IInventoryService>();

        if (inventoryService != null)
        {
       
            Item item = inventoryService.PickUpNearestItem(playerObject.transform.position);
            if (item != null)
            {

                // ������������ �������
                inventoryService.UseItem(item);
                Debug.Log("����� ����������� �������");
                item.gameObject.SetActive(false);
                
            }
        }
        else
        {
            Debug.LogError("��������� IInventoryService �� ������ �� ������� Player");
        }
    }
}
