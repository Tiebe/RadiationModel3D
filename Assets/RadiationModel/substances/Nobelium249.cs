using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium249 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium249";
        public override double halfLife { get; } = 6e-05d;
        public override double atomicWeight { get; } = 249.08781d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    