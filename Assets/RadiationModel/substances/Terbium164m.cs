using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium164m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium164m";
        public override double halfLife { get; } = 120.0d;
        public override double atomicWeight { get; } = 163.93348d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    