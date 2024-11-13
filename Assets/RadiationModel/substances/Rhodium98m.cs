
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium98m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium98m";
        public override double halfLife { get; } = 216.0d;
        public override double atomicWeight { get; } = 97.91077d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.89d, new List<RadioactiveSubstance> { new GammaParticle(), new Rhodium98() } },

            { 0.11d, new List<RadioactiveSubstance> { new BetaParticle(), new Ruthenium98() } },

        };
    }
}
    
    