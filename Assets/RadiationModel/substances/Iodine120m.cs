using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine120m : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine120m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 119.91017d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01698, 73000.0), new Iodine120() } },

        };
    }
}
    
    