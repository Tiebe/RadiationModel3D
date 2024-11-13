
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium106 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium106";
        public override double halfLife { get; } = 32123520.0d;
        public override double atomicWeight { get; } = 105.90733d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Rhodium106() } },

        };
    }
}
    
    