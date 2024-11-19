using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nitrogen14i : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen14i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 14.00556d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00054, 2312590.2), new Nitrogen14() } },

        };
    }
}
    
    