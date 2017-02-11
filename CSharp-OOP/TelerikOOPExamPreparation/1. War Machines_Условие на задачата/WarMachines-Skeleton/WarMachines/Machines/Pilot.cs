namespace WarMachines.Machines
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;

    using Interfaces;
    using Common;

    public class Pilot : IPilot   // 1-ва стъпка правим си клас пилот, който имплементира интерфейса ипилот, имплементираме му нещата
                                  // и му правим нова колекция за машините, които ще му добавяме
    {
        private string name;

        private ICollection<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();   // инстанцираме си колекцията за машините в конструктора 
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Pilot name can not be null!");

                this.name = value;
            }
        }

        public ICollection<IMachine> Machines
        {
            get { return this.machines; }
            private set
            {
                Validator.CheckIfNull(value, "List of machines cannot be null.");
                
                this.machines = value;
            }
        }

        public void AddMachine(IMachine machine)   // 2-ра стъпка имплементира ме си аддмашиин метода 
        {
            Validator.CheckIfNull(machine, "Null machines can not be added to pilot!"); // за всеки случай, проверяваме дали машината е нълл  с валидатора (подаваме му двата параметъра нещото което ще проверява и съобщението!)

            this.machines.Add(machine);
        }

        public string Report()  // 3-та стъпка да сортирам машините(първо по хеалт поинтс после по име) и да имплементираме репорта(който ще принтира на конзолата )
        {
            var sortedMachines = this.machines.OrderBy(m => m.HealthPoints).ThenBy(m => m.Name);  // ето така ги сортираме чрез линкЮ
                                                                                                  // много са удобни тия изрази на 1 ред и приоверка итова което да принти.. ако е тру броя на мапините ще изпринти ако е фолс "no"
            var noMachinesMaybe = this.machines.Count > 0 ? this.machines.Count.ToString() : "no";  // проверяваме дали има машини или не (ако има броя на машините принтим ако ли не пишем NO )
                                                                                                    // гледаме си от репорт екземпъла, как точно да направим репорта, следва от него да си напишем машини в множествено или единствено число са (“machine”/”machines”)
            var pluralMachinesMaybe = this.machines.Count == 1 ? "machine" : "machines";    // етка така !

            // следва да добавим остатъка от пърият ред от (pilot name) – (number of machines/”no”) (“machine”/”machines”) към краиният ни резултат

            var result = new StringBuilder();  // 
            result.AppendLine(string.Format("{0} - {1} {2}", this.Name, noMachinesMaybe, pluralMachinesMaybe));// първо е името след това интервал - интервам броя на машЗините и след това думичката машин или машинес

            foreach (var machine in sortedMachines)  // и сега си добавяме  това което всяка една машина трябва да принтира(на всяка машина какви са и нешата - (machine name)
            {                                                                                                                                          // *Type: (“Tank”/”Fighter”)
                result.AppendLine(machine.ToString());
            }

            return result.ToString().Trim();  // за да си махнем допълнителни празни редове, който бъркат събм,ита !!!
        }
    }
}
