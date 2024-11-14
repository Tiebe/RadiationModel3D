using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium222 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium222";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 222.02605d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10498047.4), new Thorium218() } },

        };
    }
}
    
    