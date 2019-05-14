using AWModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Data;
using System.Collections.Generic;
using System.Diagnostics;

namespace QueryTests
{


  [TestClass()]
  public class SalesEntitiesTest
  {

    [TestMethod]
    public void MiniCustomerProjectionReturnsListOfTypedObjects()
    {

      Assert.IsTrue(ExploreQueryProjections() is List<MiniCustomer>);
    }

    private List<MiniCustomer> ExploreQueryProjections()
    {

      var context = new SalesEntities();
      var query = from c in context.Customers select new MiniCustomer { FirstName = c.FirstName, LastName = c.LastName, CustomerID = c.CustomerID };
      return query.ToList();
      //foreach (var whatever in query)
      //  Debug.WriteLine(whatever.FirstName.Trim() + ' ' + whatever.LastName);

    }




    [TestMethod]
    public void QueryingWithNavigationProperties()
    {
      var context = new SalesEntities();


            //var query = from c in context.Customers
            //            where c.Orders.Sum(o => o.SubTotal) > 10000
            //            from o in c.Orders
            //            select new { c.Company, Orders = o };
            
            ////par navegar entre la informacion
            var orders = (from o in context.Orders
                          where o.Customer.SalesPerson == "linda3"
                          select new { o.SalesOrderNumber, o.Customer.Company }).ToList();
            //aqui lo que estoy haciendo es que cogo los customers y le digo que las ordenes de se customers haga una suma
            //de todos los subtotales que pertenecen a ese customer sumelos osea haga un total final y luego lo compara
            //si es mayor que 1000 y crea un objeto anomimo que tiene los campos company y orders 
            //hace que la consulta se anidada y que sea mas limpia en sql (from o in c.Orders)
            //esto me da una sola orden no una coleccion de ordenes 
            var query2 = from c in context.Customers
                        where c.Orders.Sum(o=>o.SubTotal)>1000
                        from o in c.Orders
                        select new { c.Company, o };

            var query = from c in context.Customers 
                  where c.Orders.Any() 
                  select new { c.Company, Orders = c.Orders };
      var customers = query.ToList();


    }

    [TestMethod]
    public void NestedQuery()
    {
      var context = new SalesEntities();

      var universe = from c in context.Customers where c.Orders.Any() select c;

      var queryA = (from c in universe select new { c.Company, c.Orders.Count }).ToList();

      // var queryB=from c in universe select c;


      //another type of nested query

      var nested = from c in context.Customers
                   from o in c.Orders
                   where o.OnlineOrderFlag == true
                   select new { c.Company, o.SalesOrderNumber };

    }
    [TestMethod]
    public void GroupedQueries()
    {
      var context = new SalesEntities();

      var query = from o in context.Orders
                  group o by o.DueDate
                    into mygroupedorders
                    select mygroupedorders;

            foreach(var g in query)
            {
                Debug.WriteLine("Due date: {0}", g.Key);
                foreach(var o in g)
                {
                    Debug.WriteLine(o.PurchaseOrderNumber);
                }
            }
    }



    [TestMethod]
    public void ReturnsASingleCustomer()
    {
      var context = new SalesEntities();
     Order order=(from o in context.Orders orderby o.SubTotal descending select o).SingleOrDefault();
      Assert.IsNotNull(order);
    
     
    }

 [TestMethod]
    public void GetObjectByKeyReturnsAnObject()
    {

      var context=new SalesEntities();
      var key=new EntityKey("SalesEntities.Customers","CustomerID",16);
      object customer;
      Assert.IsTrue(context.TryGetObjectByKey(key, out customer));
      Assert.IsInstanceOfType(customer, typeof(Customer));
    }

  }

  




 public class MiniCustomer
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int CustomerID { get; set; }
 
  }
 
}

