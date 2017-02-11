namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Common;
    using Interfaces;
    public abstract class Machine : IMachine   // следваща стъпка след като си направим пилота и неговата имплементация , да си направим нов абстрактен клас машиин
    {                                        //  за да не повтаряме и за файтъра и за танка един и същ код

        private string name;      // правим си и поле за валидацията на името и така , след това си правим папка Commoн и клас за валидатор(Validator) (понеже имаме повторение на кода(за валидацията ))
        private IPilot pilot;
        private IList<string> targets;
        protected Machine(string name, double attackPoints, double defensePoints, double healthPoints) //  правим си конструктор за машината разборасе... като от MachineFactory можем да видим какво неща ще трябва даподадем на машината и следователно в конструктора + double healthPoints
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;
            this.targets = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Machine name can not be null!");

                this.name = value;
            }
        }

        public IPilot Pilot   // пилота трябва да има валидация затова му правим и поле
        {
            get
            {
                return this.pilot;
            }
            set
            {
                Validator.CheckIfNull(value, "Pilot can not be null!");   // валидираме си го с валидатора

                this.pilot = value;
            }
        }

        public double AttackPoints { get; protected set; }   // след това си прваим автоматични тия пропъртита понеже не ни търсят валидация в условието

        public double DefensePoints { get; protected set; } // след това си прваим автоматични тия пропъртита понеже не ни търсят валидация в условието

        public double HealthPoints { get; set; }  // и това си го правим автоматично пропърти


        public IList<string> Targets    // таргетите трябва да ги върнем, като лист , затова си правим поле за тях от лист и си инстанцираме този лист в конструктор
        {
            get
            {
                return new List<string>(this.targets); // правим така за да си енкспулираме поленцето и да си го защитим!!!!
            }
        }

        public void Attack(string target)    // и тук ни остава атаката да си имплементираме
        {
            Validator.CheckIfStringIsNullOrEmpty(target); // за всеки случай си валидираме тия данни ....!!! 
            this.targets.Add(target);    // ето така си добавяме към таргета
        }
        // следва да си добавим танк и файтър класовеете ... и след това да си оувърайтнем toString

        // това е последната част от задачата да оувърайтнем toString
        public override string ToString()
        {
            var result = new StringBuilder();

                            // ако имаме повече от нула направими ги разделени със запетайки, ако ли не върни ми "None"
            var targetsAsString = this.targets.Count > 0 ? string.Join(", ", this.targets) : "None";  // ето тука си ги изваждаме за по прегледно

            // първо му вкараваме този ред: - (machine name)
            result.AppendLine(string.Format("- {0}", this.Name));

            // след това трябва да му добавим типа на машината: *Type: (“Tank”/”Fighter”)
            result.AppendLine(string.Format(" *Type: {0}", this.GetType().Name));

            // след това ни трябва  Health на машината: *Health: (machine health points)
            result.AppendLine(string.Format(" *Health: {0}", this.HealthPoints));

            // след това ни трябва  Attack на машината: *Attack: (machine attack points)
            result.AppendLine(string.Format(" *Attack: {0}", this.AttackPoints));

            // след това ни трябва  Defense на машината: *Defense: (machine defense points)
            result.AppendLine(string.Format(" *Defense: {0}", this.DefensePoints));

            // след това ни трябва  Targets на машината: *Targets: (machine target names/”None” – comma separated)  // None ако няма и разделени със запетайки, ако има
            result.AppendLine(string.Format(" *Targets: {0}", targetsAsString));  // най-добре да си ги извадим отгоре !

            return result.ToString(); 
        }
        // сега ни остава да си overritnem ToString  и в танка и изтребитела + тези неща от тук от базовия ToString за всички машини
    }
}
