using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine33i : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine33i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 32.98341d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((5548400.0, 0.00022)), new Chlorine33() } },

        };
    }
}
    
    