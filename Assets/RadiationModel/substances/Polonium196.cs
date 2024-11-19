using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium196 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium196";
        public override double halfLife { get; } = 5.63d;
        public override double atomicWeight { get; } = 195.98554d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.94d, new List<RadioactiveSubstance> { new AlphaParticle(7680002.09), new Lead192() } },

        };
    }
}
    
    