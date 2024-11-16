using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium173m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium173m";
        public override double halfLife { get; } = 2.2d;
        public override double atomicWeight { get; } = 172.96775d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.88d, new List<RadioactiveSubstance> { new BetaParticle(1, 7396000.0), new Osmium173() } },
            { 0.12d, new List<RadioactiveSubstance> { new AlphaParticle(6962047.4), new Rhenium169() } },

        };
    }
}
    
    