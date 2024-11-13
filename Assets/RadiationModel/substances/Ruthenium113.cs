
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium113 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium113";
        public override double halfLife { get; } = 0.8d;
        public override double atomicWeight { get; } = 112.92284d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Rhodium113() } },

        };
    }
}
    
    