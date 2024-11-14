using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium178n : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium178n";
        public override double halfLife { get; } = 978265512.0d;
        public override double atomicWeight { get; } = 177.94633d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00051), new Hafnium178() } },

        };
    }
}
    
    