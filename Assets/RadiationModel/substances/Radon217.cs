using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon217 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon217";
        public override double halfLife { get; } = 0.00059d;
        public override double atomicWeight { get; } = 217.00393d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8910002.09), new Polonium213() } },

        };
    }
}
    
    