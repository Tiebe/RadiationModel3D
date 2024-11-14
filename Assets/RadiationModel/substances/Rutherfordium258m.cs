using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium258m : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium258m";
        public override double halfLife { get; } = 0.0034d;
        public override double atomicWeight { get; } = 258.10471d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    