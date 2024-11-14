using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium162 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium162";
        public override double halfLife { get; } = 2.7d;
        public override double atomicWeight { get; } = 161.94162d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4343900.0), new Europium162() } },

        };
    }
}
    
    