
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium244 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium244";
        public override double halfLife { get; } = 18072.0d;
        public override double atomicWeight { get; } = 244.06518d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 6e-05d, new List<RadioactiveSubstance> { new AlphaParticle(), new Americium240() } },

        };
    }
}
    
    