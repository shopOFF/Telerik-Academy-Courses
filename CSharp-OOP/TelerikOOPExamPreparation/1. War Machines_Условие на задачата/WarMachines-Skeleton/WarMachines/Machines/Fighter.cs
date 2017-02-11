namespace WarMachines.Machines
{
    using System.Text;

    using Interfaces;
    public class Fighter : Machine, IMachine, IFighter  // правим си изтребитела, имлементирам си неговите и общите за вс машини интерфейси 
    {
        private const int InitialHealthPoints = 200;  // това е първоначалната кръв на всеки изтребител
        public Fighter(string name, double attackPoints, double defensePoints,bool stealthMode)   // базовия конструктор + първоначалната му кръв 
            : base(name, attackPoints, defensePoints, InitialHealthPoints)
        {
            //  this.Name = name;  ...  // може ид а не си ги пием тези от базовия конструктор, 

            this.StealthMode = stealthMode;   // взимаме си задължително новото нещо  което, ни се иска при самото създавеане на изтребител
        }

        public bool StealthMode { get; private set; }  // имплементираме си стелтмода
        

        public void ToggleStealthMode()  // и следва да си обърнем този мод 
        {
            this.StealthMode =! this.StealthMode;  // просито си го обръщаме( ОН И ОФФ) така се включва и изкючва
        }

        // сега остава да си довършим задачата като имплементираме и tostring в машините


        // // това е последната част от задачата да оувърайтнем toString + базовия оувърайт

        public override string ToString()
        {
            var baseString = base.ToString();  // ето така си визмаме от базовия оувърайт

            var result = new StringBuilder();

            result.Append(baseString);  // ето така си взимаме базовия за да е преди новите неща,само Append защото AppendLine(новия ред)вече е добавен

            // сега следват новите неща те пак с AppendLine си ги добавяме 
            // първоот е  *Stealth: (“ON”/”OFF” – when applicable)
            result.Append(string.Format(" *Stealth: {0}", this.StealthMode ? "ON" : "OFF")); // тука директно си вкарваме израза с тернарния оператор, за по бързо!!! и само Append, защото с AppendLine ни връща допълнителни празни редове, който бъркат събм,ита

            return result.ToString();  //и това е връщаме си резултат и сме ок и с fighter-a
        }
    }
}
