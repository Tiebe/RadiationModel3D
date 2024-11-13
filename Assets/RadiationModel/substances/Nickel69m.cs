
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel69m : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel69m";
        public override double halfLife { get; } = 3.5d;
        public override double atomicWeight { get; } = 68.93595d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Copper69() } },

            { 0.0001d, new List<RadioactiveSubstance> { new GammaParticle(), new Nickel69() } },

        };
    }
}
    
    