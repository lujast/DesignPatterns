using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public class ConcretePrototype : IPrototype
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private DbData dbData;

        public DbData GetDataFromDb()
        {
            return this.dbData;
        }


        public void  SetDbData()
        {

            System.Threading.Thread.Sleep(2000);
            this.dbData = new DbData() { DbDataId = new Random().Next(1, 100) };
        }

        public IPrototype Clone(bool deepCopy)
        {
            ConcretePrototype copy = new ConcretePrototype();
            copy = this.MemberwiseClone() as ConcretePrototype;
            
            if(deepCopy)
            {
                copy.dbData=new DbData();
                copy.dbData.DbDataId = this.dbData.DbDataId;
            }

            return copy;
        }


        public  class DbData
        {
            public int DbDataId { get; set; }
        }
    }

    
}
