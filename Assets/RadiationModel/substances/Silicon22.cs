
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon22 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon22";
        public override double halfLife { get; } = 0.0287d;
        public override double atomicWeight { get; } = 22.03611d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Aluminum22() } },

        };
    }
}
    
    