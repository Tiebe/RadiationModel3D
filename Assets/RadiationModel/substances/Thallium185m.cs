using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium185m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium185m";
        public override double halfLife { get; } = 1.93d;
        public override double atomicWeight { get; } = 184.97928d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00272, 455000.0), new Thallium185() } },

        };
    }
}
    
    