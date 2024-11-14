using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium76 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium76";
        public override double halfLife { get; } = 36.5d;
        public override double atomicWeight { get; } = 75.93507d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8534900.0), new Krypton76() } },

        };
    }
}
    
    