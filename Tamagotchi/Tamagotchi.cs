public class Tamagotchi{

    public string name;

    private int hunger;

    private int boredom;

    private List<string> words = new();

    private bool isAlive = true;

    private Random random = new();


    public void Tick(){

        hunger++;
        boredom++;

        if (hunger > 10 || boredom > 10){
            isAlive = false;
        }

    }

    private void reduceBoredom(){

        boredom--;

        if (boredom < 0){
            boredom = 0;
        }
    }
    public void Feed(){

        int z = random.Next(1, 4);

        hunger = hunger - z;

        if (hunger < 0){
            hunger = 0;
        }
        
    }
    
    public void Hi(){

        int z = random.Next(words.Count());

        System.Console.WriteLine($"{name} says: {words[z]}!");

        if (words.Count() < 1){

            System.Console.WriteLine($"{name} doesn't know any words yet, please teach them some!");
        }
        reduceBoredom();

    }    

    public void Teach(){
        System.Console.WriteLine($"Please say the word you wish to teach {name}!");
        string word = Console.ReadLine();
        words.Add(word);
        System.Console.WriteLine($"You have taught {name} a new word!");
        
        reduceBoredom();
    }
    
    public bool getAlive(){

        return isAlive;
    }
}