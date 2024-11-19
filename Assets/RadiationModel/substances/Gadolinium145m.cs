using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium145m : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium145m";
        public override double halfLife { get; } = 85.0d;
        public override double atomicWeight { get; } = 144.92251d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.943d, new List<RadioactiveSubstance> { new GammaParticle((749000.0, 0.00166)), new Gadolinium145() } },
            { 0.057d, new List<RadioactiveSubstance> { new BetaParticle(1, 5814000.0), new Europium145() } },

        };
    }
}
    
    