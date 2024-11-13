
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium164m : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium164m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 163.95014d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Samarium164() } },

        };
    }
}
    
    