using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium155 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium155";
        public override double halfLife { get; } = 8.9d;
        public override double atomicWeight { get; } = 154.93314d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4656000.0), new Promethium155() } },

        };
    }
}
    
    