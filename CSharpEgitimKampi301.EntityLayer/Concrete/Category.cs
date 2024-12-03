using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {

        //Access Modifiers (Erişim Belirleyici);
        //public : Her yerden erişim var 
        //Private : sadece bulundugu class dan bulunduıgu interface den alandan erişim saglar.
        //Internal :Sadece bulundugu katmandan erişim .
        //PRotected : Sınıf o sınıfı miras alan alanları alır.

        /*Field - Variable-Property
         * int x : Field  classın icinde direk tanımlanırsa.
         * public int y { get; set;} : Property
         * void test (){
         * int z
         * } methot icimnde tanımlanırsa Variable degişken
        */

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }

        public List<Product> Products { get; set; }



    }
}
