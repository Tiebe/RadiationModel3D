using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium200 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium200";
        public override double halfLife { get; } = 7.0d;
        public override double atomicWeight { get; } = 199.98009d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3020000.0), new Iridium200() } },

        };
    }
}
    
    