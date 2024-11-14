using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium111 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium111";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 110.90418d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    