//main
Console.Clear();
string choice = "";
while(choice != "4"){
    Console.WriteLine("Please select which pizza to display. Enter a number.\n1. Plain Pizza\n2. Cheese Pizza\n3. Pepperoni Pizza\n4. Exit");
    choice = Console.ReadLine()!;
    PizzaMenu(choice);
}
//end main


static void PizzaMenu(string choice){
    switch(choice){
        case "1":
            PlainPizza();
            Pause();
            break;
        case "2":
            CheesePizza();
            Pause();
            break;
        case "3":
            PepperoniPizza();
            Pause();
            break;
        case "4":
            SayBye();
            break;
        default:
            Console.WriteLine("Invalid input. Please try again.");
            Pause();
            break;
    }
}

static int PizzaRows(){
    int rows = 0;
    int check = 1;

    while(check > 0){
        Random rnd = new Random();
        rows = rnd.Next(13);
        if (rows >= 8){
            check -= check;
        }
        else{
            check ++;
        }
    }
    return rows;
}

static void PlainPizza(){
    Console.Clear();
    for(int i = PizzaRows(); i > 0; i --){
        for(int j = 0; j < i; j++){
            Console.Write("* ");
        }
        Console.WriteLine();
    }
}


static void CheesePizza(){
    int rows = PizzaRows();

    Console.Clear();
    for(int i = rows; i > 0; i--){
        for(int j = 0; j < i; j++){
            if( i == rows || j == 0 || j == i - 1){
                Console.Write("* ");
            }
            else{
                Console.Write("# ");
            }
        }
        Console.WriteLine();
    }
}

static int CheeseOrPepporoni(){
    Random rnd = new Random();
    int CheeseOrPep = rnd.Next(2);
    return CheeseOrPep;
}

static void PepperoniPizza(){
    //let if random number = 1, write cheese, if 2 write pep
    int rows = PizzaRows();

    Console.Clear();
    for(int i = rows; i > 0; i--){
        for(int j = 0; j < i; j++){
            if( i == rows || j == 0 || j == i - 1){
                Console.Write("*  ");
            }

            else{
                int CheeseOrPep = CheeseOrPepporoni();
                if(CheeseOrPep == 0){
                    Console.Write("#  ");
                }
                else{
                    Console.Write("[] ");
                }
            }
        }
        Console.WriteLine();
    }
}


static void SayBye(){
    Console.WriteLine("Goodbye!");
}

static void Pause(){
    Console.WriteLine("Press any key to continue.");
    Console.ReadKey();
}