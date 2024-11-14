using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium173 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium173";
        public override double halfLife { get; } = 7.1d;
        public override double atomicWeight { get; } = 172.94702d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4300000.0), new Erbium173() } },

        };
    }
}
    
    