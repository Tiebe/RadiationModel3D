using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum173 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum173";
        public override double halfLife { get; } = 0.382d;
        public override double atomicWeight { get; } = 172.97645d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.86d, new List<RadioactiveSubstance> { new AlphaParticle(7378047.4), new Osmium169() } },

        };
    }
}
    
    