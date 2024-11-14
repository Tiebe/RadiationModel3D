using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton93 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton93";
        public override double halfLife { get; } = 1.287d;
        public override double atomicWeight { get; } = 92.93115d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8484000.0), new Rubidium93() } },

        };
    }
}
    
    