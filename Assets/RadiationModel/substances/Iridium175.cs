using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium175 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium175";
        public override double halfLife { get; } = 9.0d;
        public override double atomicWeight { get; } = 174.96415d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9915d, new List<RadioactiveSubstance> { new BetaParticle(1, 6710000.0), new Osmium175() } },
            { 0.0085d, new List<RadioactiveSubstance> { new AlphaParticle(6452002.09), new Rhenium171() } },

        };
    }
}
    
    