
//Exercice 1
{
Dictionary<string, string> dayTrad= new Dictionary<string, string>();

dayTrad.Add("Lundi","Monday");
dayTrad.Add("Mardi","Tuesday");
dayTrad.Add("Mercredi","Wednesday");
dayTrad.Add("Jeudi","Thursday");
dayTrad.Add("Vendredi","Friday");
dayTrad.Add("Samedi","Saturday");
dayTrad.Add("Dimanche","Sunday");

string dayToTrad = Console.ReadLine();

if (dayToTrad != null) // check if user putInput not empty
{
    if (dayTrad.ContainsKey(dayToTrad)) // check if the key exist in the dictionary
    {
        Console.WriteLine(dayTrad[dayToTrad]); // print the value of the key
    }
    else
    {
        Console.WriteLine("Day not found");
    }
}
else 
    Console.WriteLine("put an imput please");

}

//Exercice 2

{
Dictionary<string, int> lstNoteStudent = new Dictionary<string, int>() {
    {"John", 10},
    {"Paul", 12},
    {"George", 14},
    {"Ringo", 8},
    {"Pete", 16},
    {"Stuart", 18},
    {"Mick", 20},
    {"Keith", 22},
    {"Ronnie", 24},
    {"Charlie", 10},  
};

int nbStudent = 0;
int totalNote = 0;
double averageNote = 0;
int maxNote = 0;
int minNote = 0;



foreach (var note in lstNoteStudent) // var --> typage dinamique, il comprend automatiquement le type de note (kvp ici[string, int])
{
    totalNote += note.Value; // add the value of the note to the total
    if (note.Value > maxNote || nbStudent == 0) // take the first student value as the first max value found
    {
        maxNote = note.Value;
    }
    if (note.Value < minNote || nbStudent == 0) // take the first student value as the first min value found
    {
        minNote = note.Value;
    }
    nbStudent++; // increment the number of student (for the average)
}

if (nbStudent != 0) // check division by 0
    averageNote = totalNote / nbStudent; // calculate the average

Console.WriteLine("Average note : " + averageNote);
Console.WriteLine("Max note : " + maxNote);
Console.WriteLine("Min note : " + minNote);



}

//Exercice 3


//Exercice 3.2

Contacts contacts = new Contacts();

contacts.AddContact("John", "0123456789");
contacts.AddContact("Paul", "9123456789");
contacts.AddContact("Bob", "9999999999");
contacts.AddContact("Hulk", "1111112222");
contacts.AddContact("JKRolling", "3333444489");
contacts.AddContact("Bob", "9999799999");
contacts.AddContact("Rob", "9a999n9999");
contacts.AddContact("Lob", "9999999999999");

string [] lstContact = contacts.GetAllContacts();

foreach (string c in lstContact)
{
    Console.WriteLine(c);

}

contacts.changeContact("JKRolling", "0000000000");
contacts.changeContact("jfdkslafjkl", "0000000000");
contacts.deleteContact("jfskld");
contacts.deleteContact("John");
contacts.deleteContact("Hulk", "fjdskafdkas");


string [] lst2Contact = contacts.GetAllContacts();

foreach (string c in lst2Contact)
{
    Console.WriteLine(c);

}

Console.WriteLine("we are looking for stephan :" + contacts.FindContact("stephan"));
Console.WriteLine("we are looking for Paul:" + contacts.FindContact("9123456789"));

contacts.deleteContact("Hulk", "1111112222");

string [] lst3Contact = contacts.GetAllContacts();

foreach (string c in lst3Contact)
{
    Console.WriteLine(c);

}

public class Contacts {
    public Dictionary<string, string> lstContacts = new Dictionary<string, string>();

    // lstContacts<nom, numero de telephone> --> pas good parce que un numero est unique a une personne alors qu'une personne peut avoir plusieur num de telephone

    public void AddContact(string name, string phoneNumb) {
        if (lstContacts.ContainsKey(name)) { // check if the name exist in the dictionary
            Console.WriteLine("Contact already exist");
            return;
        }
        if (phoneNumb.Length != 10) { // check if the phone number is 10 digits
            Console.WriteLine("Phone number must contains 10 digits");
            return;
        }
        for (int i = 0; i < 10; i++) { // check if the phone number is a number or use methode to check if only number in string
            if (phoneNumb[i] < '0' || phoneNumb[i] > '9') { 
                Console.WriteLine("Phone number must be only numbers");
                return;
            }
        }
        lstContacts.Add(name, phoneNumb);
    }

    public void deleteContact(string str) {
        if (lstContacts.ContainsKey(str))
            lstContacts.Remove(str);
        else if (lstContacts.ContainsValue(str)) // check if the value exist in the dictionary
        {
            foreach (var number in lstContacts) {  // loop through the dictionary
                if (number.Value == str) {
                    lstContacts.Remove(number.Key); // remove the contact by the key of the value
                    break; // stop looping
                    // return; // autre solution possible pour arreter le parcourt du dictionnaire
                }
            }
        }
    }

    public void deleteContact(string name, string phone) {
        string number = "";
        if (lstContacts.ContainsKey(name)) // check if the name and the phone number exist in the dictionary
        {
            number = lstContacts[name]; // get the phone number of the name
            if (number == phone) // check if the phone number is the same than the one in the dictionary
            {
                lstContacts.Remove(name);
            }
            else 
            {
                Console.WriteLine("name doesn't match with the number delete" );
                Console.WriteLine("name given :" + name + " phoneNumber associeted :" + lstContacts[name] + " , number researched for delete : " + phone);
            }
            return ;
        }
        Console.WriteLine("name : " + name + "doesn't exist in contactlist");
    }

    public void changeContact(string name, string newNumber) {
       if (newNumber.Length != 10) { // check if the phone number is 10 digits
            Console.WriteLine("Phone number must be 10 digits");
            return;
        }
        for (int i = 0; i < 10; i++) { // check if the phone number is a number
            if (newNumber[i] < '0' || newNumber[i] > '9') { 
                Console.WriteLine("Phone number must be a number");
                return;
            }
        }
        if (lstContacts.ContainsKey(name)) // check if the name and the phone number exist in the dictionary
        {
            lstContacts[name] = newNumber; // change the phone number of the name
        }
    }

    public string GetContact(string name) {
        if (lstContacts.ContainsKey(name)) // check if the name exist in the dictionary
        {
            return lstContacts[name]; // return the phone number of the name
        }
        return ""; // if not found return null
    }

    public string FindContact(string phone) {
        foreach (var number in lstContacts) { // loop through the dictionary
            if (number.Value == phone) {
                return number.Key; // return the name of the phone number
            }
        }
        return ""; // if not found return null
    }

    public string [] GetAllContacts() {
        int nbrContactInLst = lstContacts.Count;
        string [] contacts = new string[nbrContactInLst]; // create a string array with the size of the dictionary
        int i = 0;

        foreach (var contact in lstContacts) { // loop through the dictionary
            contacts[i] = "Nom : " + contact.Key + " , numero : " + contact.Value; // add the name and the phone number to the array
            i++;
        }

/*
        for (int j = 0; j < nbrConstactInLst; j++) {

        }
*/

        return contacts;
    }
}



//Exercice 4

public class Cours {
    public Dictionary<string, double> priceProduct = new Dictionary<string, double>();
    public List<string> lstProduct = new List<string>();

    public Cours() {
    }

    public void PriceProductAleatory(string productName) {
        Random random = new Random();
        double price = random.NextDouble(); // generate a random number between 0 et 1

        // range 0 et 1 * (maximun  - minimun) + minimun
        price = price * (18.99 - 1) + 1; // generate a random number between 1 and 18.99

        if (priceProduct.ContainsKey(productName)) // check if the product exist in the dictionary
        {
            Console.WriteLine("Product already exist");
            return;
        }
        else 
        {
            priceProduct.Add(productName, price); // add the product and the price to the dictionary
        }
    }

    public void addProduct(string newProduct) {
        lstProduct.Add(newProduct); // add the product to the list
    }

    public void addMultipleProduct(string [] newProduct) {
        foreach (string product in newProduct) { // loop through the array
            lstProduct.Add(product); // add the product to the list
        }
    }

    public void removeProduct(string product) {
        if (lstProduct.Contains(product)) // check if the product exist in the list
        {
            lstProduct.Remove(product); // remove the product from the list
        }
    }

    public void removeMultipleProduct(string [] product) {
        foreach (string p in product) { // loop through the array
            this.removeProduct(p); // autre solution 
        }
    }   

    public void PriceProduct(string productName, int price) {
        if (priceProduct.ContainsKey(productName)) // check if the product exist in the dictionary
        {
            Console.WriteLine("Product already exist");
            return;
            // priceProduct[productName] = price;
        } // on aurait pu comprendre la redifinition du prix produit plutot que ne rien faire
        else 
        {
            priceProduct.Add(productName, price); // add the product and the price to the dictionary
        }
    }

    public void PriceProduct(string[] productsNames, int[] prices) {
        if (productsNames.Length != prices.Length) // check if the array have the same size
        {
            Console.WriteLine("The array must have the same size");
            return;
        }
        for (int i = 0; i < productsNames.Length; i++) {
            PriceProduct(productsNames[i], prices[i]); // call the function PriceProduct
        }
    }

    public double GetPriceLstProducts() {
        double totalPrice = 0;
        foreach (string product in lstProduct) { // loop through the list
            if (priceProduct.ContainsKey(product)) // check if the product exist in the dictionary
            {
                totalPrice += priceProduct[product]; // add the price of the product to the total price
            }
            else 
            {
                PriceProductAleatory(product); // call the function PriceProductAleatory
                totalPrice += priceProduct[product]; // add the price of the product to the total price

            }
        }
        return totalPrice;
    }

}

