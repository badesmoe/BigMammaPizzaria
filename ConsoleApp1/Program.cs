using ConsoleApp1;

CustomerFile customers = new();
customers.Add(new Customer("Rikke", "Knud Den Stores Vej 43D 1.TV", 28260143));
customers.Add(new Customer("Lars", "Kongens Nytorv 12 2.TH", 99887766));
customers.Add(new Customer("Mette", "Frederiksberg Allé 45 3.MF", 33445566));
customers.Add(new Customer("Søren", "Nørrebrogade 78 4.TV", 77665544));
customers.Add(new Customer("Anna", "Vesterbrogade 23 5.TH", 11223344));
customers.Add(new Customer("Peter", "Amagerbrogade 67 6.MF", 44332211));
customers.Add(new Customer("Katrine", "Østerbrogade 89 7.TH", 55667788));

PizzaMenu menu = new();
menu.Add(1, new Pizza("Margherita", 59.0));
menu.Add(2, new Pizza("Pepperoni", 69.0));
menu.Add(3, new Pizza("Hawaiian", 64.0));
menu.Add(4, new Pizza("Veggie", 62.0));
menu.Add(5, new Pizza("BBQ Chicken", 75.0));
menu.Add(6, new Pizza("Meat Lovers", 80.0));
menu.Add(7, new Pizza("Four Cheese", 70.0));
menu.Add(8, new Pizza("Supreme", 85.0));
menu.Add(9, new Pizza("Buffalo", 78.0));
menu.Add(10, new Pizza("Mediterranean", 72.0));
menu.Add(11, new Pizza("Spicy Tuna", 500.87));
menu.Add(12, new Pizza("Spicy Tuna 2", 500.87));

OrderFile orderlist = new();

orderlist.Add(new Order(customers.Search("Rikke")!, menu.GetPizza(1)!));
orderlist.Add(new Order(customers.Search("Lars")!, menu.GetPizza(3)!));
orderlist.Add(new Order(customers.Search("Mette")!, menu.GetPizza(5)!));
orderlist.Add(new Order(customers.Search("Søren")!, menu.GetPizza(2)!));

orderlist.PrintAll();

Console.WriteLine($"Pizzas sold: {orderlist.TotalPizzas()}\n" +
    $"Total revenue: {orderlist.TotalRevenue()} DKK");