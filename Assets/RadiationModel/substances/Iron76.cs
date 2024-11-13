
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron76 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron76";
        public override double halfLife { get; } = 0.003d;
        public override double atomicWeight { get; } = 75.98863d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    