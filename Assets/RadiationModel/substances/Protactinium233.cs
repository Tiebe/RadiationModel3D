
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium233 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium233";
        public override double halfLife { get; } = 2330640.0d;
        public override double atomicWeight { get; } = 233.04025d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Uranium233() } },

        };
    }
}
    
    