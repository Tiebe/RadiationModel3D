
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium196 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium196";
        public override double halfLife { get; } = 2.4d;
        public override double atomicWeight { get; } = 195.976d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    