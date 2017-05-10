using Academy.Commands.Contracts;
using Academy.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Academy.Commands.Adding
{
    internal class AddStudentToSeasonCommandFake : AddStudentToSeasonCommand
    {
        public AddStudentToSeasonCommandFake(IAcademyFactory factory, IEngine engine)
            : base(factory, engine)
        {
        }

        public IAcademyFactory Factory
        {
            get { return base.Factory; }
        }

        public IEngine Engine
        {
            get { return base.Engine; }
        }
    }
}
