
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium214 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium214";
        public override double halfLife { get; } = 0.00016d;
        public override double atomicWeight { get; } = 213.9952d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Lead210() } },

        };
    }
}
    
    