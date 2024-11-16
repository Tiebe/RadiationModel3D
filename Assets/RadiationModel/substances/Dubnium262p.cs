using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium262p : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium262p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 262.11412d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    