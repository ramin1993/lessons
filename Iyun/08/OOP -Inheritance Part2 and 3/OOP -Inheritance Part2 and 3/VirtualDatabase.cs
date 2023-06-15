using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__Inheritance_Part2_and_3
{
    class VirtualDatabase
    {

        private ArrayList arrDB;
        public VirtualDatabase()
        {
            arrDB = new ArrayList();
        }

        //NewItem methodu bir parametr almalıdır. NewItem array'a tək məhsul əlavə edəcək.
        public void NewItem(Base bs)
        {
            arrDB.Add(bs);
            for(int i = 0; i < arrDB.Count; i++)
            {
                Base item = (Base)arrDB[i];
                item.ToString();
            }
        }

        //NewItems methodu təyin olunan zaman 1 parametr yazılacaq ancaq istifadə edilən yerdə istədiyim qədər Tv və ya 
       // Laptop tipində fərqli dəyişənlər ötürə biləcəm

        public void NewItems(params Base[] bs)
        {
                arrDB.Add(bs);

           for(int i = 0; i < arrDB.Count; i++)
            {
                Base items = (Base)arrDB[i];
                items.ToString();
            }
            
        }

        //UpdateItem methodu isə hər hansısa məhsulun dəyərlərini update edəcək.
        public void UpdateItem(Base[] bs,Base updateValue)
        {
            for(int i = 0; i < bs.Length; i++)
            {
                bs[i] =updateValue;
            }
        }


        public void DeleteItem()
        {

            for (int i = 0; i < arrDB.Count; i++) {
                Base item = (Base)arrDB[i];
                item.IsDeleted = true;
                item.DeleteDate = DateTime.Now;
                item.DeleteUser = 10;
            }
           
        }

        public bool CheckAllBarcode(Base bs)
        {

            for(int i = 0; i < arrDB.Count; i++)
            {
                Base items = (Base)arrDB[i];
               items.CheckBarcodeMethod(bs);
                
            }
            return true;
        }
    }
}
