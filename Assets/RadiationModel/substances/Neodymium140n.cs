using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium140n : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium140n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 139.91753d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00017, 7435000.0), new Neodymium140() } },

        };
    }
}
    
    