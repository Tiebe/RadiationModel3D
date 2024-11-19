using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium41i : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium41i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 40.96852d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00021, 5817110.0), new Calcium41() } },

        };
    }
}
    
    