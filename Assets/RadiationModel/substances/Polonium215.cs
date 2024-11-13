
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium215 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium215";
        public override double halfLife { get; } = 0.00178d;
        public override double atomicWeight { get; } = 214.99942d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Lead211() } },

            { 2.3e-06d, new List<RadioactiveSubstance> { new BetaParticle(), new Astatine215() } },

        };
    }
}
    
    