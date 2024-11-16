using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium146 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium146";
        public override double halfLife { get; } = 174509944.56d;
        public override double atomicWeight { get; } = 145.9147d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.66d, new List<RadioactiveSubstance> { new Neodymium146() } },
            { 0.34d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1542000.0), new Samarium146() } },

        };
    }
}
    
    