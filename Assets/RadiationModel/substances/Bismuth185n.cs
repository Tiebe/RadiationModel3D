
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth185n : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth185n";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 184.99779d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    