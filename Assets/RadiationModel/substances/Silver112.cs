using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver112 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver112";
        public override double halfLife { get; } = 11268.0d;
        public override double atomicWeight { get; } = 111.90705d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3991160.0), new Cadmium112() } },

        };
    }
}
    
    