
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron63 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron63";
        public override double halfLife { get; } = 6.1d;
        public override double atomicWeight { get; } = 62.94027d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cobalt63() } },

        };
    }
}
    
    