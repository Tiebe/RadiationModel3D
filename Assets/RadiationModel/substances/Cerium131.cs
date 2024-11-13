
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium131 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium131";
        public override double halfLife { get; } = 618.0d;
        public override double atomicWeight { get; } = 130.91443d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lanthanum131() } },

        };
    }
}
    
    