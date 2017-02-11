namespace WarMachines.Engine
{
    using WarMachines.Interfaces;
    using WarMachines.Machines;

    public class MachineFactory : IMachineFactory
    {
        public IPilot HirePilot(string name) //(от тук виждаме в конструктора какво задължително да има при създаването на този обект!!!!)
        {
            // TODO: Implement this method
            return new Pilot(name);   // създаваме си нов пилот!!!!(и му даваме необходимите параметри)
        }

        public ITank ManufactureTank(string name, double attackPoints, double defensePoints)//(от тук виждаме в конструктора какво задължително да има при създаването на този обект!!!!)
        {
            // TODO: Implement this method
            return new Tank(name, attackPoints, defensePoints); // създаваме си нов танк(и му даваме необходимите параметри)
        }

        public IFighter ManufactureFighter(string name, double attackPoints, double defensePoints, bool stealthMode)//(от тук виждаме в конструктора какво задължително да има при създаването на този обект!!!!)
        {
            // TODO: Implement this method
            return new Fighter(name, attackPoints, defensePoints, stealthMode); // създаваме си нов изтребител(и му даваме необходимите параметри)
        }
    }
}
