
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Roentgenium281 : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium281";
        public override double halfLife { get; } = 19.0d;
        public override double atomicWeight { get; } = 281.16675d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.87d, new List<RadioactiveSubstance> {  } },

            { 0.13d, new List<RadioactiveSubstance> { new AlphaParticle(), new Meitnerium277() } },

        };
    }
}
    
    