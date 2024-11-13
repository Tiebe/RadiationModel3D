
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium257 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium257";
        public override double halfLife { get; } = 8683200.0d;
        public override double atomicWeight { get; } = 257.09511d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9979d, new List<RadioactiveSubstance> { new AlphaParticle(), new Californium253() } },

            { 0.0021d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    