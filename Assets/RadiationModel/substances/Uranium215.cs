using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium215 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium215";
        public override double halfLife { get; } = 0.0014d;
        public override double atomicWeight { get; } = 215.02672d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    