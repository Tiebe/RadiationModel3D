using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium174 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium174";
        public override double halfLife { get; } = 44.0d;
        public override double atomicWeight { get; } = 173.95706d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3678000.0), new Rhenium174() } },
            { 0.00024d, new List<RadioactiveSubstance> { new AlphaParticle(5891047.4), new Tungsten170() } },

        };
    }
}
    
    