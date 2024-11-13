
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium192 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium192";
        public override double halfLife { get; } = 15.4d;
        public override double atomicWeight { get; } = 191.96609d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Osmium192() } },

        };
    }
}
    
    