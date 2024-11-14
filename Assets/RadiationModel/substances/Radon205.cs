using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon205 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon205";
        public override double halfLife { get; } = 170.0d;
        public override double atomicWeight { get; } = 204.99172d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.754d, new List<RadioactiveSubstance> { new BetaParticle(1, 5275000.0), new Astatine205() } },
            { 0.24600000000000002d, new List<RadioactiveSubstance> { new AlphaParticle(7406047.4), new Polonium201() } },

        };
    }
}
    
    