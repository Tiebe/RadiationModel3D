
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum153 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum153";
        public override double halfLife { get; } = 0.245d;
        public override double atomicWeight { get; } = 152.95055d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cerium153() } },

        };
    }
}
    
    