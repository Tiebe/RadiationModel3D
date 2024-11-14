using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium100 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium100";
        public override double halfLife { get; } = 74880.0d;
        public override double atomicWeight { get; } = 99.90811d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3636400.0), new Ruthenium100() } },
            { 0.951d, new List<RadioactiveSubstance> { new Ruthenium100() } },
            { 0.049d, new List<RadioactiveSubstance> { new BetaParticle(1, 3636400.0), new Ruthenium100() } },

        };
    }
}
    
    