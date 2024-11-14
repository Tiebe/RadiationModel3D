using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium173 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium173";
        public override double halfLife { get; } = 9.0d;
        public override double atomicWeight { get; } = 172.96751d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.965d, new List<RadioactiveSubstance> { new BetaParticle(1, 7170000.0), new Osmium173() } },
            { 0.035d, new List<RadioactiveSubstance> { new AlphaParticle(6736047.4), new Rhenium169() } },

        };
    }
}
    
    