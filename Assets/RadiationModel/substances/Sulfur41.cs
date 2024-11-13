
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur41 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur41";
        public override double halfLife { get; } = 1.99d;
        public override double atomicWeight { get; } = 40.97959d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Chlorine41() } },

        };
    }
}
    
    