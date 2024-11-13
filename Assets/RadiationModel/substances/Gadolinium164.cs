
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium164 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium164";
        public override double halfLife { get; } = 45.0d;
        public override double atomicWeight { get; } = 163.93592d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Terbium164() } },

        };
    }
}
    
    