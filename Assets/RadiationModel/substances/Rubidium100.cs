
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium100 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium100";
        public override double halfLife { get; } = 0.0513d;
        public override double atomicWeight { get; } = 99.95033d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Strontium100() } },

        };
    }
}
    
    