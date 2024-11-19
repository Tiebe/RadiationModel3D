using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium140m : RadioactiveSubstance
    {
        public override string name { get; } = "Europium140m";
        public override double halfLife { get; } = 0.125d;
        public override double atomicWeight { get; } = 139.92831d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((210000.0, 0.0059)), new Europium140() } },
            { 0.01d, new List<RadioactiveSubstance> { new BetaParticle(1, 8676000.0), new Samarium140() } },

        };
    }
}
    
    