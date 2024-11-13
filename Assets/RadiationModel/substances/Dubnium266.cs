
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium266 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium266";
        public override double halfLife { get; } = 4800.0d;
        public override double atomicWeight { get; } = 266.12103d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    