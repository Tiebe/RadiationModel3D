
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine35 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine35";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 34.96885d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    