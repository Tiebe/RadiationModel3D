
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium141m : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium141m";
        public override double halfLife { get; } = 24.5d;
        public override double atomicWeight { get; } = 140.93253d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.89d, new List<RadioactiveSubstance> { new BetaParticle(), new Europium141() } },

            { 0.11d, new List<RadioactiveSubstance> { new GammaParticle(), new Gadolinium141() } },

        };
    }
}
    
    