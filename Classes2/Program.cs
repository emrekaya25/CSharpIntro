using Classes2;

Product product1 = new Product();
//product1.ProductName = "Laptop";
product1.UnitsInStock = 18;
product1.UnitPrice = 10800;


Product product2 = new Product() { ProductName="Monitör",UnitPrice=3000,UnitsInStock=21};

ProductManager productManager = new ProductManager(product1.ProductName);
ProductManager productManager1 = new ProductManager(product2);
productManager.Add(product1);
