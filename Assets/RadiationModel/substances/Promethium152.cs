
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium152 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium152";
        public override double halfLife { get; } = 247.2d;
        public override double atomicWeight { get; } = 151.92351d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Samarium152() } },

        };
    }
}
    
    