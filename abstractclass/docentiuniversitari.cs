namespace docentiuniversitari
{
    public abstract class Docente
    {//Esempio di classe astratta
    //una classe che non può essere istanziata direttamente
    //ma che può essere ereditata da altre classi
        public  Docente()
        {
            
        }
    }
public abstract class Professore: Docente
    {//Esempio di classe astratta derivata
    //una classe che eredita da una classe astratta
    //e che non può essere istanziata direttamente
    //ma che può essere ereditata da altre classi
        public Professore()
        {

        }
        public  void Bonus()
        {

        }
    }   
    public  class Ricercatore: Professore
    {//Esempio di classe concreta
    //una classe che eredita da una classe astratta
    //e che può essere istanziata direttamente
        public Ricercatore()
        {

        }
        public  void Bonus()//Override del metodo Bonus della classe Professore
        //Una classe concreta deve implementare tutti i metodi astratti delle classi astratte da cui eredita
        //ma in questo caso il metodo Bonus non è astratto, quindi non è obbligatorio implementarlo
        {

        }
    }

}