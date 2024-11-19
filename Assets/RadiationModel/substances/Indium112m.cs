using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium112m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium112m";
        public override double halfLife { get; } = 1240.2d;
        public override double atomicWeight { get; } = 111.90571d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0079, 157000.0), new Indium112() } },

        };
    }
}
    
    