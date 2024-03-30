using System;
using System.Collections.Generic;
using System.Data;

namespace WFThesisManagementSystem.Helper
{
    public class GroupIdGenerator
    {   
        private List<int> ints = new List<int>();

        public GroupIdGenerator(DataTable tableMemberNumber) {

            for (int i = 1; i < 101; i++)
            {
                ints.Add(i);
            }
            UpdateList(tableMemberNumber, ints);
        }
        

        private void UpdateList (DataTable tableMemberNumber, List<int> intList)
        {
            foreach(DataRow row in tableMemberNumber.Rows)
            {
                if (intList.Contains(Convert.ToInt32(row["group_id"])))
                {
                    intList.Remove(Convert.ToInt32(row["group_id"]));
                }

            }
        }

        public int GenerateGroupID()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, ints.Count); // Sinh số ngẫu nhiên từ 0 đến số phần tử trong danh sách
            return ints[randomIndex];
        }
        
    }
}
