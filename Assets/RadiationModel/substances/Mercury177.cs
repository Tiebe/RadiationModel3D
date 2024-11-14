using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury177 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury177";
        public override double halfLife { get; } = 0.117d;
        public override double atomicWeight { get; } = 176.98628d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(7755047.4), new Platinum173() } },

        };
    }
}
    
    