using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium203 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium203";
        public override double halfLife { get; } = 0.3d;
        public override double atomicWeight { get; } = 202.9922d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    