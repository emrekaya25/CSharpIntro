using Project5.Business;
using Project5.DataAccess;

ProductManager productManager = new ProductManager(new EfProductDal());
foreach (var product in productManager.GetAll())
{
    Console.WriteLine(product.ProductName);
}
