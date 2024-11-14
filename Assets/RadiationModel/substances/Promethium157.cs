using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium157 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium157";
        public override double halfLife { get; } = 10.56d;
        public override double atomicWeight { get; } = 156.93312d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4381000.0), new Samarium157() } },

        };
    }
}
    
    