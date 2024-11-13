
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon39 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon39";
        public override double halfLife { get; } = 0.0412d;
        public override double atomicWeight { get; } = 39.00249d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Phosphorus39() } },

        };
    }
}
    
    