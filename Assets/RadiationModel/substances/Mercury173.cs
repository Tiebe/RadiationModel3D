
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury173 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury173";
        public override double halfLife { get; } = 0.0008d;
        public override double atomicWeight { get; } = 172.99714d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Platinum169() } },

        };
    }
}
    
    