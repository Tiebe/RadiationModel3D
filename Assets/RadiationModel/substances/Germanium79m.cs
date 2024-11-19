using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium79m : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium79m";
        public override double halfLife { get; } = 39.0d;
        public override double atomicWeight { get; } = 78.92556d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.96d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4296000.0), new Arsenic79() } },
            { 0.04d, new List<RadioactiveSubstance> { new GammaParticle((190000.0, 0.00653)), new Germanium79() } },

        };
    }
}
    
    