using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum190 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum190";
        public override double halfLife { get; } = 1.5242007816e+19d;
        public override double atomicWeight { get; } = 189.95995d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(4288547.4), new Osmium186() } },

        };
    }
}
    
    