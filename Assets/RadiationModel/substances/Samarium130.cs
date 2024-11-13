
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium130 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium130";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 129.94879d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    