
public class Counter
{
    //parametr klasy - zmienna typu int o poziomie ochrony 'private' = nie bedzie dostepna z poziomu obiektu, tylko z poziomu klasy
    private int Result = 0;


    //konstruktory - są zawsze wywolywane przy tworzeniu obiektu klasy
    //bezparametrowy - mozna tworzyc obiekt bez żadnych arg
    //przyklad: Counter c1 = new Counter()
    public Counter() {}

    //zparametryzowany - mozna tworzyc obiekt z podaniem arg i cos z tym arg zrobic.. np przypisac go gdzies do zmiennej
    //przyklad: Counter c1 = new Counter(5)
    public Counter(int result)
    {
        Result = result;
    }




    //metody klasy - getter i setter do pobierania wartosci zmiennej prywatnej i do jej ustawiania
    public int GetResult()
    {
        return Result;
    }

    public void SetResult(int x)
    {
        Result = x;
    }




    //metody klasy
    public void Add(int x)
    {
        Result += x;
    }
    public void Subtract(int x)
    {
        Result -= x;
    }
}
