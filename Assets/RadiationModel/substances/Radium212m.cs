using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium212m : RadioactiveSubstance
    {
        public override string name { get; } = "Radium212m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 212.00189d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00063, 1958000.0), new Radium212() } },

        };
    }
}
    
    