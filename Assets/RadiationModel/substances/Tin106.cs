using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin106 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin106";
        public override double halfLife { get; } = 115.2d;
        public override double atomicWeight { get; } = 105.91696d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3254000.0), new Indium106() } },

        };
    }
}
    
    