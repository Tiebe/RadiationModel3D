
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium195 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium195";
        public override double halfLife { get; } = 4.64d;
        public override double atomicWeight { get; } = 194.98807d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.94d, new List<RadioactiveSubstance> { new AlphaParticle(), new Lead191() } },

        };
    }
}
    
    