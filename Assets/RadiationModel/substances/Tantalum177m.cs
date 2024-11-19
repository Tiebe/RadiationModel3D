using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum177m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum177m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 176.94456d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01698, 73000.0), new Tantalum177() } },

        };
    }
}
    
    