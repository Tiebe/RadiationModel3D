
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium159 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium159";
        public override double halfLife { get; } = 11.37d;
        public override double atomicWeight { get; } = 158.93322d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Europium159() } },

        };
    }
}
    
    