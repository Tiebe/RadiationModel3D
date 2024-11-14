using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel65 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel65";
        public override double halfLife { get; } = 9063.0d;
        public override double atomicWeight { get; } = 64.93008d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2137900.0), new Copper65() } },

        };
    }
}
    
    