
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium161m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium161m";
        public override double halfLife { get; } = 300.0d;
        public override double atomicWeight { get; } = 160.93356d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    