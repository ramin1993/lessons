using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__Inheritance_Part2_and_3
{
    class Base
    {
        private int _id;
        public int Id {
            get {
                return _id;
            }
            private set {

            }
        }

        private int Barcode;
        public int CheckBarcode
        {
            get {
                return Barcode;
                }
            set
            {
                
                if (IsDeleted == true)
                {
                    Barcode = value;
                }
                else
                {
                    Console.WriteLine("Bu barkod daha once basqa mehsul ucun sisteme elave olunub!");
                }
            }
        }

        public void CheckBarcodeMethod(Base bs)
        {
            bs.CheckBarcode.ToString();
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        private double BuyPrice;
        private double SellPrice;
        private double OfferPrice;
        public DateTime? CreateDate;
        public int CreateUser { get; set; }
        public DateTime? EditDate;
        public int EditUser { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeleteDate;
        public int DeleteUser { get; set; }

        //Id dəyəri hər dəfə Laptop və ya Tv yaradılan zaman özü artsın (random yox). Set oluna bilməsin. Get oluna bilər.
        
        private int counter = 0;
        public Base()
        {
            counter++;
            _id = counter;
        }

        public double CheckBuyPrice
        {
            get
            {
                return this.BuyPrice;
            }
            set
            {
                
                if (BuyPrice < 1)
                {
                    Console.WriteLine("Alis qiymeti 1 den kicik ola bilmez!");
                }
                else
                {
                    BuyPrice = value;
                }
            }
        }

        public double CheckSellPrice
        {
            get
            {
                return SellPrice;
            }
            set
            {
                
                if (SellPrice < BuyPrice)
                {
                    Console.WriteLine("Satis qiymeti alis qiymetinden az ola bilmez!");
                }
                else
                {
                    SellPrice = value;
                }
            }
        }

        public double CheckOfferPrice
        {
            get
            {
                return OfferPrice;
            }
            set
            {
                
                if(OfferPrice < 1)
                {
                    Console.WriteLine("Kompaniya qiymeti 1-den kicik ola bilmez!");
                }
                else
                {
                    OfferPrice = value;
                }
            }
        }
    }
}
