
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon219 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon219";
        public override double halfLife { get; } = 3.96d;
        public override double atomicWeight { get; } = 219.00948d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Polonium215() } },

        };
    }
}
    
    