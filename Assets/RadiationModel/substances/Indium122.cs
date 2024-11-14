using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium122 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium122";
        public override double halfLife { get; } = 1.5d;
        public override double atomicWeight { get; } = 121.91028d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6370000.0), new Tin122() } },

        };
    }
}
    
    