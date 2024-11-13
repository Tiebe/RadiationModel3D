
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium159 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium159";
        public override double halfLife { get; } = 4e-05d;
        public override double atomicWeight { get; } = 158.9841d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    