
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon223 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon223";
        public override double halfLife { get; } = 1458.0d;
        public override double atomicWeight { get; } = 223.02189d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Francium223() } },

        };
    }
}
    
    