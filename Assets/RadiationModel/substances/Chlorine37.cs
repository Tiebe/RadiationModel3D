using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine37 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine37";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 36.9659d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    