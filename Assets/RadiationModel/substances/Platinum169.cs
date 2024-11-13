
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum169 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum169";
        public override double halfLife { get; } = 0.00699d;
        public override double atomicWeight { get; } = 168.98662d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Osmium165() } },

        };
    }
}
    
    