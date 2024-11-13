
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium95m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium95m";
        public override double halfLife { get; } = 117.6d;
        public override double atomicWeight { get; } = 94.91648d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.88d, new List<RadioactiveSubstance> { new GammaParticle(), new Rhodium95() } },

            { 0.12d, new List<RadioactiveSubstance> { new BetaParticle(), new Ruthenium95() } },

        };
    }
}
    
    