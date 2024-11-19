using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium48i : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium48i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 47.96025d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00021, 5793000.0), new Chromium48() } },

        };
    }
}
    
    