
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon31 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon31";
        public override double halfLife { get; } = 9429.6d;
        public override double atomicWeight { get; } = 30.97536d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Phosphorus31() } },

        };
    }
}
    
    