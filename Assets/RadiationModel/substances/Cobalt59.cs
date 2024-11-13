
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt59 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt59";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 58.93319d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    