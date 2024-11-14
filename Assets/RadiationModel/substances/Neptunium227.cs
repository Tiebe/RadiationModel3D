using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium227 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium227";
        public override double halfLife { get; } = 0.51d;
        public override double atomicWeight { get; } = 227.03498d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8835047.4), new Protactinium223() } },

        };
    }
}
    
    