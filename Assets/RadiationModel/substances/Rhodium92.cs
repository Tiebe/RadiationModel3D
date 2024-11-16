using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium92 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium92";
        public override double halfLife { get; } = 5.61d;
        public override double atomicWeight { get; } = 91.93237d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 11302200.0), new Ruthenium92() } },

        };
    }
}
    
    