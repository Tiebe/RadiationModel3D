using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium127 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium127";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 126.95136d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    