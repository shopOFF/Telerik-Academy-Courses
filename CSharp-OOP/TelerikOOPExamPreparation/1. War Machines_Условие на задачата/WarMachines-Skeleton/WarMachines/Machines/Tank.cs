namespace WarMachines.Machines
{
    using System.Text;

    using Interfaces;
    public class Tank : Machine, IMachine, ITank  // наследяваме си машината , интерфейсите имашин и итанк (описваме си и 2-та интерфейса, защото така е по-лесно разбираемо)
    {
        private const int InitialHealthPoints = 100;   // изваждаме си в константа първоначалната кръв на танка понеже си я знаем !
        private const int AttckPointsChange = 40;
        private const int DefensePointsChange = 30;

        public Tank(string name, double attackPoints, double defensePoints)   // викаме си базовия коннструктор + InitialHealthPoints !!!
            : base(name, attackPoints, defensePoints, InitialHealthPoints)
        {
            //  this.Name = name;  ...  // може ид а не си ги пием тези от базовия конструктор, 
            // TODO: start defense mode
            this.DefenseMode = true;
            this.DefensePoints += DefensePointsChange;  // за да им сетнем първоначалните стойности
            this.AttackPoints -= AttckPointsChange;
        }

        public bool DefenseMode { get;private set; } // не ни трябва валидация затова автоматично проп си правим

        public void ToggleDefenseMode()  //да обърнем дефенс мода от тру на фолс и от фолс на тру и да добавим или извадим някакви точки според условието
        {                               // по дефоут дефенс мода му е пуснат
            //this.DefenseMode = !this.DefenseMode;  // ако е тру направи го фолс, ако е фолс направио го тру!
            if (this.DefenseMode)  // ако дефенс мода е вкл  става това 
            {
                this.DefenseMode = false; // ако е тру направи го фолс, ако е фолс направио го тру! и доло си ги обръщаме пак
                this.AttackPoints += AttckPointsChange;
                this.DefensePoints -= DefensePointsChange;
            }
            else                     // ако се изключи дефенс мода пак си се връщат на първоназалните стойности
            {
                this.DefenseMode = true;
                this.AttackPoints -= AttckPointsChange;
                this.DefensePoints += DefensePointsChange;
            }
        }
        // следва да направим файтъра(изтребитела)

        // // това е последната част от задачата да оувърайтнем toString + базовия оувърайт

        public override string ToString()
        {
            var baseString = base.ToString();  // ето така си визмаме от базовия оувърайт

            var result = new StringBuilder();

            result.Append(baseString);  // ето така си взимаме базовия за да е преди новите неща,само Append защото AppendLine(новия ред)вече е добавен

            // сега следват новите неща те пак с AppendLine си ги добавяме 
            // първоот е  *Defense: (“ON”/”OFF” – when applicable)
            result.Append(string.Format(" *Defense: {0}", this.DefenseMode ? "ON" : "OFF")); // тука директно си вкарваме израза с тернарния оператор, за по бързо!!! и само Append, защото с AppendLine ни връща допълнителни празни редове, който бъркат събм,ита

            return result.ToString();  //и това е връщаме си резултат и сме ок с танка, остава fighter
        }
    }
}
