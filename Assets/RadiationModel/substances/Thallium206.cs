using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium206 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium206";
        public override double halfLife { get; } = 252.12d;
        public override double atomicWeight { get; } = 205.97611d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1532200.0), new Lead206() } },

        };
    }
}
    
    