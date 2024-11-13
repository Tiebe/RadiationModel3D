
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium144 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium144";
        public override double halfLife { get; } = 31363200.0d;
        public override double atomicWeight { get; } = 143.9126d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Neodymium144() } },

            { 8.000000000000001e-07d, new List<RadioactiveSubstance> { new BetaParticle(), new Neodymium144() } },

        };
    }
}
    
    