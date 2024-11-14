using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium120 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium120";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 119.90407d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    