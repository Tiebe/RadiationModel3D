using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony128 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony128";
        public override double halfLife { get; } = 32580.0d;
        public override double atomicWeight { get; } = 127.90915d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4363800.0), new Tellurium128() } },

        };
    }
}
    
    