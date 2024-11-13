
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium157 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium157";
        public override double halfLife { get; } = 29304.0d;
        public override double atomicWeight { get; } = 156.92547d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Terbium157() } },

        };
    }
}
    
    