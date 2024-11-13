
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium178 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium178";
        public override double halfLife { get; } = 300.0d;
        public override double atomicWeight { get; } = 177.95325d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Rhenium178() } },

        };
    }
}
    
    