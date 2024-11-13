
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium149 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium149";
        public override double halfLife { get; } = 0.349d;
        public override double atomicWeight { get; } = 148.94328d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lanthanum149() } },

        };
    }
}
    
    