
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Meitnerium267 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium267";
        public override double halfLife { get; } = 0.01d;
        public override double atomicWeight { get; } = 267.13719d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    