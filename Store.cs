using System;
using System.Collections.Generic;

public class Store
{
    Good iPhone12 = new Good("IPhone 12");
    Good iPhone11 = new Good("IPhone 11");

    Warehouse warehouse = new Warehouse();

    Shop shop = new Shop(warehouse);

    warehouse.Delive(iPhone12, 10);
    warehouse.Delive(iPhone11, 1);

    //Вывод всех товаров на складе с их остатком

    Cart cart = shop.Cart();
    cart.Add(iPhone12, 4);
    cart.Add(iPhone11, 3); //при такой ситуации возникает ошибка так, как нет нужного количества товара на складе

    //Вывод всех товаров в корзине

    Console.WriteLine(cart.Order().Paylink);

    cart.Add(iPhone12, 9); //Ошибка, после заказа со склада убираются заказанные товары
}

public class Good
{
    private string _model;

    public Good(string model)
    {
        _model = model;
    }
}

public class Warehouse
{
    private List<Box> _boxes = new List<Box>();

    public void Delive(Good good, int count)
    {

    }
}

public class Shop
{
    private Warehouse _warehouse;

    public Shop(Warehouse warehouse)
    {
        _warehouse = warehouse;
    }
}

public class Cart
{

}

public class Box
{
    private Good _good;
    private int _count;

    public Box(Good good, int count)
    {
        if (count <= 0)
            throw new ArgumentOutOfRangeException(nameof(count));

        _good = good;
        _count = count;
    }
}