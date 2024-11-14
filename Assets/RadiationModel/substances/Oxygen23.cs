using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oxygen23 : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen23";
        public override double halfLife { get; } = 0.097d;
        public override double atomicWeight { get; } = 23.0157d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11330000.0), new Fluorine23() } },

        };
    }
}
    
    