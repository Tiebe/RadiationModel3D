
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium268p : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium268p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 268.12583d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    