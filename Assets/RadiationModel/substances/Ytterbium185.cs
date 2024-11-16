using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium185 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium185";
        public override double halfLife { get; } = 5.0d;
        public override double atomicWeight { get; } = 184.96943d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    