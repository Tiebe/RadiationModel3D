using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Meitnerium270 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium270";
        public override double halfLife { get; } = 0.8d;
        public override double atomicWeight { get; } = 270.14032d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(11205047.4), new Bohrium266() } },

        };
    }
}
    
    