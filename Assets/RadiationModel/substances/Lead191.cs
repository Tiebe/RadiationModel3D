using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead191 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead191";
        public override double halfLife { get; } = 79.8d;
        public override double atomicWeight { get; } = 190.97822d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5992000.0), new Thallium191() } },
            { 0.0051d, new List<RadioactiveSubstance> { new AlphaParticle(6423047.4), new Mercury187() } },

        };
    }
}
    
    