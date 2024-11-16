using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium191 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium191";
        public override double halfLife { get; } = 1295136.0d;
        public override double atomicWeight { get; } = 190.96093d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 313600.0), new Iridium191() } },

        };
    }
}
    
    