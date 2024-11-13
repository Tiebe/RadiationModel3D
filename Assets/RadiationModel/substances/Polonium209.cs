
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium209 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium209";
        public override double halfLife { get; } = 3913062048.0d;
        public override double atomicWeight { get; } = 208.98243d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.99546d, new List<RadioactiveSubstance> { new AlphaParticle(), new Lead205() } },

            { 0.00454d, new List<RadioactiveSubstance> { new BetaParticle(), new Bismuth209() } },

        };
    }
}
    
    