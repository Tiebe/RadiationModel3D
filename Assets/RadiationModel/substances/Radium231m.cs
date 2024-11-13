
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium231m : RadioactiveSubstance
    {
        public override string name { get; } = "Radium231m";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 231.0411d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Radium231() } },

        };
    }
}
    
    