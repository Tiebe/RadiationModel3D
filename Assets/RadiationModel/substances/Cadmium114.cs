using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium114 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium114";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 113.90336d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    