using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium169 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium169";
        public override double halfLife { get; } = 283.2d;
        public override double atomicWeight { get; } = 168.93688d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2125200.0), new Erbium169() } },

        };
    }
}
    
    