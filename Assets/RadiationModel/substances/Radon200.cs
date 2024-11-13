
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon200 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon200";
        public override double halfLife { get; } = 1.09d;
        public override double atomicWeight { get; } = 199.99571d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.92d, new List<RadioactiveSubstance> { new AlphaParticle(), new Polonium196() } },

        };
    }
}
    
    