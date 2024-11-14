using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium161 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium161";
        public override double halfLife { get; } = 1.05d;
        public override double atomicWeight { get; } = 160.94623d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6585000.0), new Samarium161() } },

        };
    }
}
    
    