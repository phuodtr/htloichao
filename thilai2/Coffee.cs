using System;
using System.Collections.Generic;

namespace thilai2
{
    public class Coffee
    {
        private Dictionary<int, Table> Tables;
        public Coffee()
        {
            Tables = new Dictionary<int, Table>();
        }
         public void NewOrder(Table table)
        {
            Tables.Add(table.TableId, table);
        }
       public void UpdateOrder(int TableId,Table table)
        {
         for (int i = 0; i < Tables.Count; i++)
         {
             if(Tables[i].TableId == TableId)
             Tables[i] = table;
         }
        }
       public void CancelOrder(Table table) 
        {
           bool search = false;
            Console.Write("Nhap TableId cua Table ma ban muon xoa : ");
            int TableId = int.Parse(Console.ReadLine());
            foreach (Table item in Tables.Values)
            {
                if (TableId.Equals(item.TableId))
                {
                    search = true;
                    Tables.Remove(TableId);
                    break;
                }
            }
            if (search == true)
                Console.WriteLine("xoa thanh cong");
            else
                Console.WriteLine("khong xoa  duoc!");
        }
       public int Search(int TableId)
        {
             for (int i = 0; i < Tables.Count; i++)
         {
             if(Tables[i].TableId == TableId)
             return 1;
         }
         return 0;
        }
       public void  show()
        {
        }
      public  void Pay()
        {
        }

      
    }
}