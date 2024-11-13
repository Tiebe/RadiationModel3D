
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine200m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine200m";
        public override double halfLife { get; } = 47.0d;
        public override double atomicWeight { get; } = 199.99047d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.43d, new List<RadioactiveSubstance> { new AlphaParticle(), new Bismuth196() } },

            { 0.57d, new List<RadioactiveSubstance> { new BetaParticle(), new Polonium200() } },

        };
    }
}
    
    