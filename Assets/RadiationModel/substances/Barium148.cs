
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium148 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium148";
        public override double halfLife { get; } = 0.62d;
        public override double atomicWeight { get; } = 147.93822d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lanthanum148() } },

        };
    }
}
    
    