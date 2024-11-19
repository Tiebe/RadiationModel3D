using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium148 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium148";
        public override double halfLife { get; } = 4708800.0d;
        public override double atomicWeight { get; } = 147.91809d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3039100.0), new Samarium148() } },
            { 9.4e-09d, new List<RadioactiveSubstance> { new AlphaParticle(3716102.09), new Promethium144() } },

        };
    }
}
    
    