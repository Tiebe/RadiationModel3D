using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium169 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium169";
        public override double halfLife { get; } = 0.353d;
        public override double atomicWeight { get; } = 168.97628d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.53d, new List<RadioactiveSubstance> { new AlphaParticle(7161047.4), new Rhenium165() } },

        };
    }
}
    
    