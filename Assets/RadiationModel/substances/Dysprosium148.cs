
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium148 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium148";
        public override double halfLife { get; } = 198.0d;
        public override double atomicWeight { get; } = 147.92715d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Terbium148() } },

        };
    }
}
    
    