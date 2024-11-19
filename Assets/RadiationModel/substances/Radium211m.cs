using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium211m : RadioactiveSubstance
    {
        public override string name { get; } = "Radium211m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 211.00218d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00103, 1198000.0), new Radium211() } },

        };
    }
}
    
    