
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium173 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium173";
        public override double halfLife { get; } = 22.4d;
        public override double atomicWeight { get; } = 172.95981d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.996d, new List<RadioactiveSubstance> { new BetaParticle(), new Rhenium173() } },

            { 0.004d, new List<RadioactiveSubstance> { new AlphaParticle(), new Tungsten169() } },

        };
    }
}
    
    