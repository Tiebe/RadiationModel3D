using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium172m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium172m";
        public override double halfLife { get; } = 2.19d;
        public override double atomicWeight { get; } = 171.97076d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.905d, new List<RadioactiveSubstance> { new BetaParticle(1, 10004000.0), new Osmium172() } },
            { 0.095d, new List<RadioactiveSubstance> { new AlphaParticle(7145047.4), new Rhenium168() } },

        };
    }
}
    
    