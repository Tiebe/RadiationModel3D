using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium161m : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium161m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 160.94065d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00089, 1388000.0), new Samarium161() } },

        };
    }
}
    
    