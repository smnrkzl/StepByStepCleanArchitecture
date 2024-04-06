using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Core.Persistence.Repositories;

namespace Domain.Entities
{
/*Brand sınıfı, Entity<Guid> sınıfından miras alır. Bu, Brand sınıfının bir varlık (entity) olduğunu ve 
bir Guid tipinde bir kimliğe sahip olduğunu gösterir.*/
//The Brand class inherits from the Entity<Guid> class. This indicates that the Brand class is an entity and has an identity of type Guid.
    
    public class Brand:Entity<Guid>
    {
        public string Name { get; set; }


 /*Parametre almayan bir kurucu metottur. Bu kurucu metodun içi boştur ve herhangi bir işlem gerçekleştirmez. 
 Kurucu metotlar, bir sınıftan nesne oluşturulurken kullanılan özel metotlardır. Bu metotlar, 
 sınıfın yapısını ve başlangıç durumunu belirlemek için kullanılır.*/
/*It is a constructor method that does not take any parameters. This constructor method is empty and does not perform any operations. 
Constructor methods are special methods used when creating an object from a class. 
These methods are used to determine the structure and initial state of the class.*/
        public Brand()
        {
            
        }

/*Bir Guid türünde id ve bir string türünde name parametreleri alır.Bu kurucu metot,
id ve name parametrelerini kullanarak bir Brand nesnesi oluşturur.*/
//It takes an id type Guid and a string type name parameters. This constructor method creates a Brand object using the id and name parameters.
        public Brand(Guid id, string name)
        {
            id = id;
            Name = name;
        }
    }
}
