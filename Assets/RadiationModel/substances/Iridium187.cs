
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium187 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium187";
        public override double halfLife { get; } = 37800.0d;
        public override double atomicWeight { get; } = 186.95754d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Osmium187() } },

        };
    }
}
    
    