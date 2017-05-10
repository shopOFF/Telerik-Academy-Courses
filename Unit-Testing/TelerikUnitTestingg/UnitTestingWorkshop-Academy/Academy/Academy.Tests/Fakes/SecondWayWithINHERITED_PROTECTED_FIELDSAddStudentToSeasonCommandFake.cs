using Academy.Commands.Adding;
using Academy.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Fakes
{
    internal class SecondWayWithINHERITED_PROTECTED_FIELDSAddStudentToSeasonCommandFake : AddStudentToSeasonCommand
    {
        public SecondWayWithINHERITED_PROTECTED_FIELDSAddStudentToSeasonCommandFake(IAcademyFactory factory, IEngine engine) 
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
