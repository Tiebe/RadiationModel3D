
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium164 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium164";
        public override double halfLife { get; } = 180.0d;
        public override double atomicWeight { get; } = 163.93333d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Dysprosium164() } },

        };
    }
}
    
    