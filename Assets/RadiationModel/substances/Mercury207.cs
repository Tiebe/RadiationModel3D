
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury207 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury207";
        public override double halfLife { get; } = 174.0d;
        public override double atomicWeight { get; } = 206.9823d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Thallium207() } },

        };
    }
}
    
    