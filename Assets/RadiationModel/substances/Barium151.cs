
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium151 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium151";
        public override double halfLife { get; } = 0.167d;
        public override double atomicWeight { get; } = 150.95175d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lanthanum151() } },

        };
    }
}
    
    