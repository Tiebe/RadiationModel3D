
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium63 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium63";
        public override double halfLife { get; } = 0.01d;
        public override double atomicWeight { get; } = 62.99371d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    