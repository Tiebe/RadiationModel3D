using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead188 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead188";
        public override double halfLife { get; } = 25.1d;
        public override double atomicWeight { get; } = 187.98088d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.915d, new List<RadioactiveSubstance> { new BetaParticle(1, 4525000.0), new Thallium188() } },
            { 0.085d, new List<RadioactiveSubstance> { new AlphaParticle(7131002.09), new Mercury184() } },

        };
    }
}
    
    