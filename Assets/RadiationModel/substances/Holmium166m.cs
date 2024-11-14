using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium166m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium166m";
        public override double halfLife { get; } = 35741403835.2d;
        public override double atomicWeight { get; } = 165.9323d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1859800.0), new Erbium166() } },

        };
    }
}
    
    