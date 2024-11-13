
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium211 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium211";
        public override double halfLife { get; } = 186.0d;
        public override double atomicWeight { get; } = 210.99556d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.87d, new List<RadioactiveSubstance> { new AlphaParticle(), new Astatine207() } },

            { 0.13d, new List<RadioactiveSubstance> { new BetaParticle(), new Radon211() } },

        };
    }
}
    
    