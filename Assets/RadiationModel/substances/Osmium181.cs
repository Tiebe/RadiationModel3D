using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium181 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium181";
        public override double halfLife { get; } = 6300.0d;
        public override double atomicWeight { get; } = 180.95325d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2967000.0), new Rhenium181() } },

        };
    }
}
    
    