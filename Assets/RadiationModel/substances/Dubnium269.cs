
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium269 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium269";
        public override double halfLife { get; } = 10800.0d;
        public override double atomicWeight { get; } = 269.12791d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    