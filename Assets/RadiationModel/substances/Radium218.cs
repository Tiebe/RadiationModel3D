using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium218 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium218";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 218.00713d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9561047.4), new Radon214() } },

        };
    }
}
    
    