using Models;

Console.WriteLine("Bem vindo ao sistema do estacionamento!");

Console.Write("Digite o preço inicial: ");
decimal initial = 0;
decimal.TryParse(Console.ReadLine(), out initial);

Console.Write("Digite o preço por hora: ");
decimal perHour = 0;
decimal.TryParse(Console.ReadLine(), out perHour);

Console.Clear();

bool getOut = false;
Park park = new Park();

while(!getOut){
    Console.WriteLine("Digite a sua Opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    string plate = "";

    ConsoleKeyInfo input = Console.ReadKey();

    switch (input.Key)
    {
        case(ConsoleKey.D1):
        case(ConsoleKey.NumPad1):
            Console.Clear();
            Console.Write("Digite a placa do veículo para estacionar: ");
            plate = Console.ReadLine();
            Vehicle vehicle = new Vehicle(plate, initial, perHour);
            park.Vehicles.Add(vehicle);
            Console.Clear();
            break;
        case(ConsoleKey.D2):
        case(ConsoleKey.NumPad2):
            Console.Clear();
            Console.Write("\nInforme a placa do veículo para remover: ");
            plate = Console.ReadLine();
            Console.Clear();
            for(int i = 0 ; i < park.Vehicles.Count ; i++){
                if(park.Vehicles[i].plate == plate){
                    int hours = 0;
                    Console.Write("Informe a quantidade de horas que o veículo permaneceu estacionado: ");
                    int.TryParse(Console.ReadLine(), out hours);
                    park.Vehicles[i].hours = hours;
                    Console.WriteLine("\nO veículo {0} foi removido e o preço foi de R$ {1}\n", plate, park.Vehicles[i].getPrice());
                    park.Vehicles.RemoveAt(i);
                }
            }
            break;
        case(ConsoleKey.D3):
        case(ConsoleKey.NumPad3):
        Console.Clear();
        Console.WriteLine("Veículos no estacionamento: ");
            foreach (var item in park.Vehicles)
            {
                Console.WriteLine(item.plate);
            }
            Console.WriteLine("\nPressione enter para continuar...");
            Console.ReadLine();
            break;
        case(ConsoleKey.D4):
        case(ConsoleKey.NumPad4):
        Console.Clear();
            Console.WriteLine("Saindo do programa...");
            Environment.Exit(0);
            break;
        default:
            break;
    }


}
