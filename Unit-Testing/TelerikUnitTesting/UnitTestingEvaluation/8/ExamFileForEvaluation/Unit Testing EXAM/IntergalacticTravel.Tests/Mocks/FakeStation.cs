namespace IntergalacticTravel.Tests.Mocks
{
    using System.Collections.Generic;
    using Contracts;

    /// <summary>
    /// By Extending the current implementation we could expose values of the protected fields we are interested in
    /// </summary>
    public class FakeStation : TeleportStation, ITeleportStation
    {
        public FakeStation(IBusinessOwner owner, IEnumerable<IPath> galacticMap, ILocation location) : base(owner, galacticMap, location)
        {
        }

        public IBusinessOwner Owner
        {
            get { return this.owner; }
        }

        public IEnumerable<IPath> Map
        {
            get { return this.galacticMap; }
        }

        public ILocation Location
        {
            get { return this.location; }
        }
    }
}