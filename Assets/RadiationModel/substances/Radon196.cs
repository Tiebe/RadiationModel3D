using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon196 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon196";
        public override double halfLife { get; } = 0.0047d;
        public override double atomicWeight { get; } = 196.00212d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8636047.4), new Polonium192() } },

        };
    }
}
    
    