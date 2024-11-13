
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium101m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium101m";
        public override double halfLife { get; } = 10.0d;
        public override double atomicWeight { get; } = 100.9271d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    