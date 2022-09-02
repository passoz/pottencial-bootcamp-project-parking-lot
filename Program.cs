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

    switch (Console.ReadLine())
    {
        case("1"):
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            plate = Console.ReadLine();
            Vehicle vehicle = new Vehicle(plate, initial, perHour);
            park.Vehicles.Add(vehicle);
            break;
        case("2"):
            Console.WriteLine("Informe a placa do veículo para remover: ");
            plate = Console.ReadLine();
            Console.Clear();
            for(int i = 0 ; i < park.Vehicles.Count ; i++){
                if(park.Vehicles[i].plate == plate){
                    int hours = 0;
                    Console.Write("Informe a quantidade de horas: ");
                    int.TryParse(Console.ReadLine(), out hours);
                    park.Vehicles[i].hours = hours;
                    Console.WriteLine("\nO preço foi de R${0}\n", park.Vehicles[i].getPrice());
                    park.Vehicles.RemoveAt(i);
                }
            }
            break;
        case("3"):
            foreach (var item in park.Vehicles)
            {
                Console.WriteLine(item.plate);
            }
            Console.WriteLine("\nPressione enter para continuar...");
            Console.ReadLine();
            break;
        case("4"):
            Console.WriteLine("Saindo do programa.");
            Environment.Exit(0);
            break;
        default:
            break;
    }


}
