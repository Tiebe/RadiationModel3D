using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium206 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium206";
        public override double halfLife { get; } = 16.0d;
        public override double atomicWeight { get; } = 205.99866d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.884d, new List<RadioactiveSubstance> { new AlphaParticle(7943047.4), new Astatine202() } },
            { 0.11599999999999999d, new List<RadioactiveSubstance> { new BetaParticle(1, 7886000.0), new Radon206() } },

        };
    }
}
    
    