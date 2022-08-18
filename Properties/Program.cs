Product product = new Product();
product.Id = 1; // burda setter çalışıyor. --> get okuma set yazma(değer atama) gibi düşünebilirsin.
Console.WriteLine(product.Id); // burda okuma yapıyoruz get çalışıyor.

product.UnitsInStock = 1500; // set edildi
Console.WriteLine(product.UnitsInStock); // get edildi

// unitprice i alıcaz kdv li şekilde ekrana yazdırıcaz

product.UnitPrice = 500;
Console.WriteLine(product.UnitPrice);


class Product
{
    public int Id { get; set; }
    public string ProductName { get; set; }

    // convert to full property seçeneğini seçtik ve getter setter lara eriştik.
    public decimal UnitPrice { get => (unitPrice + ((unitPrice * 18) / 100)); set => unitPrice = value; } 

    // her okuma yaptığımızda artık %18 kdv alarak işlem yapacak.

    // eğer burda set kısmını silersek burda değer girilemez ve sadece okunabilen bi özellik haline gelir. (read only) buna karşılık (write only) de var.

    public decimal UnitsInStock;  // bunlara field (alan) denir.
    private decimal unitPrice;
}
