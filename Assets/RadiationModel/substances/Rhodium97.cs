
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium97 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium97";
        public override double halfLife { get; } = 1842.0d;
        public override double atomicWeight { get; } = 96.91133d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ruthenium97() } },

        };
    }
}
    
    