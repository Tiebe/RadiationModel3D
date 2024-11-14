using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium193 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium193";
        public override double halfLife { get; } = 180.0d;
        public override double atomicWeight { get; } = 192.96755d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    