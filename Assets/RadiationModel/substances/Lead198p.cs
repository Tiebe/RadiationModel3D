using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead198p : RadioactiveSubstance
    {
        public override string name { get; } = "Lead198p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 197.97505d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00044, 2822000.0), new Lead198() } },

        };
    }
}
    
    