
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury179 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury179";
        public override double halfLife { get; } = 1.05d;
        public override double atomicWeight { get; } = 178.98182d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.75d, new List<RadioactiveSubstance> { new AlphaParticle(), new Platinum175() } },

            { 0.25d, new List<RadioactiveSubstance> { new BetaParticle(), new Gold179() } },

        };
    }
}
    
    